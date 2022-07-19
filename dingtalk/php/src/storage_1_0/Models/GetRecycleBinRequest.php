<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetRecycleBinRequest extends Model
{
    /**
     * @description 回收站范围类型
     * SPACE: 空间
     * @var string
     */
    public $recycleBinScope;

    /**
     * @description 回收站范围id
     * 根据recycleBinScope传入对应的企业、应用、空间ID
     * @var string
     */
    public $scopeId;

    /**
     * @description 用户id
     *
     * @var string
     */
    public $unionId;
    protected $_name = [
        'recycleBinScope' => 'recycleBinScope',
        'scopeId'         => 'scopeId',
        'unionId'         => 'unionId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->recycleBinScope) {
            $res['recycleBinScope'] = $this->recycleBinScope;
        }
        if (null !== $this->scopeId) {
            $res['scopeId'] = $this->scopeId;
        }
        if (null !== $this->unionId) {
            $res['unionId'] = $this->unionId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetRecycleBinRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['recycleBinScope'])) {
            $model->recycleBinScope = $map['recycleBinScope'];
        }
        if (isset($map['scopeId'])) {
            $model->scopeId = $map['scopeId'];
        }
        if (isset($map['unionId'])) {
            $model->unionId = $map['unionId'];
        }

        return $model;
    }
}
