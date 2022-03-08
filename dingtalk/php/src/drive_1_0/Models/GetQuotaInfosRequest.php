<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetQuotaInfosRequest extends Model
{
    /**
     * @description 容量标识符列表
     *
     * @var string[]
     */
    public $identifiers;

    /**
     * @description 容量类型
     *
     * @var string
     */
    public $type;

    /**
     * @description 用户id
     *
     * @var string
     */
    public $unionId;
    protected $_name = [
        'identifiers' => 'identifiers',
        'type'        => 'type',
        'unionId'     => 'unionId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->identifiers) {
            $res['identifiers'] = $this->identifiers;
        }
        if (null !== $this->type) {
            $res['type'] = $this->type;
        }
        if (null !== $this->unionId) {
            $res['unionId'] = $this->unionId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetQuotaInfosRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['identifiers'])) {
            if (!empty($map['identifiers'])) {
                $model->identifiers = $map['identifiers'];
            }
        }
        if (isset($map['type'])) {
            $model->type = $map['type'];
        }
        if (isset($map['unionId'])) {
            $model->unionId = $map['unionId'];
        }

        return $model;
    }
}
