<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vsns_storage_1_0\Models\GetDentriesRequest;

use AlibabaCloud\Tea\Model;

class option extends Model
{
    /**
     * @var string[]
     */
    public $appIdsForAppProperties;
    protected $_name = [
        'appIdsForAppProperties' => 'appIdsForAppProperties',
    ];

    public function validate() {}

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
