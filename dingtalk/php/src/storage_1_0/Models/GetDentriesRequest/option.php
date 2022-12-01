<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\GetDentriesRequest;

use AlibabaCloud\Tea\Model;

class option extends Model
{
    /**
     * @description 通过指定应用id, 返回对应的可见属性，即dentry.appProperties，
     * 20
     * @var string[]
     */
    public $appIdsForAppProperties;

    /**
     * @description 是否获取文件缩略图临时链接
     * false
     * @var bool
     */
    public $withThumbnail;
    protected $_name = [
        'appIdsForAppProperties' => 'appIdsForAppProperties',
        'withThumbnail'          => 'withThumbnail',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->appIdsForAppProperties) {
            $res['appIdsForAppProperties'] = $this->appIdsForAppProperties;
        }
        if (null !== $this->withThumbnail) {
            $res['withThumbnail'] = $this->withThumbnail;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return option
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['appIdsForAppProperties'])) {
            if (!empty($map['appIdsForAppProperties'])) {
                $model->appIdsForAppProperties = $map['appIdsForAppProperties'];
            }
        }
        if (isset($map['withThumbnail'])) {
            $model->withThumbnail = $map['withThumbnail'];
        }

        return $model;
    }
}
