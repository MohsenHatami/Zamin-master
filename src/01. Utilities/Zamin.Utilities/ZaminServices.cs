﻿using Zamin.Utilities.Services.Chaching;
using Zamin.Utilities.Services.Localizations;
using Zamin.Utilities.Services.ObjectMappers;
using Zamin.Utilities.Services.Serializers;
using Zamin.Utilities.Services.Users;
using Microsoft.Extensions.Logging;

namespace Zamin.Utilities
{
    public class ZaminServices
    {
        public readonly ITranslator ResourceManager;
        public readonly ICacheAdapter CacheAdapter;
        public readonly IMapperAdapter MapperFacade;
        public readonly ILoggerFactory LoggerFactory;
        public readonly IJsonSerializer Serializer;
        public readonly IUserInfoService UserInfoService;

        public ZaminServices(ITranslator resourceManager,
                ILoggerFactory loggerFactory,
                IJsonSerializer serializer,
                IUserInfoService userInfoService,
                ICacheAdapter cacheAdapter,
                IMapperAdapter mapperFacade)
        {
            ResourceManager = resourceManager;
            LoggerFactory = loggerFactory;
            Serializer = serializer;
            UserInfoService = userInfoService;
            CacheAdapter = cacheAdapter;
            MapperFacade = mapperFacade;
        }
    }
}
