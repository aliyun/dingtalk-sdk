<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vpackage_1_0\Models;

use AlibabaCloud\Tea\Model;

class CloseHPackageRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 5000000000000000
     *
     * @var string
     */
    public $miniAppId;
    protected $_name = [
        'miniAppId' => 'miniAppId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->miniAppId) {
            $res['miniAppId'] = $this->miniAppId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CloseHPackageRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['miniAppId'])) {
            $model->miniAppId = $map['miniAppId'];
        }

        return $model;
    }
}
