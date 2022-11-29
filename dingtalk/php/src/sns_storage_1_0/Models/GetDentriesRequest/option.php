<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vsns_storage_1_0\Models\GetDentriesRequest;

use AlibabaCloud\Tea\Model;

class option extends Model
{
    /**
     * @description 通过指定应用id, 返回对应的可见属性，即dentry.appProperties，
     * 20
     * @var string[]
     */
    public $appIdsForAppProperties;
    protected $_name = [
        'appIdsForAppProperties' => 'appIdsForAppProperties',
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

        return $model;
    }
}
