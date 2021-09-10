<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Voauth2_1_0\Models\GetPersonalAuthRuleResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @description resource
     *
     * @var string
     */
    public $resource;

    /**
     * @description authItems
     *
     * @var string[]
     */
    public $authItems;
    protected $_name = [
        'resource'  => 'resource',
        'authItems' => 'authItems',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->resource) {
            $res['resource'] = $this->resource;
        }
        if (null !== $this->authItems) {
            $res['authItems'] = $this->authItems;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return result
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['resource'])) {
            $model->resource = $map['resource'];
        }
        if (isset($map['authItems'])) {
            if (!empty($map['authItems'])) {
                $model->authItems = $map['authItems'];
            }
        }

        return $model;
    }
}
