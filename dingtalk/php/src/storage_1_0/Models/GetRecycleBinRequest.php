<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetRecycleBinRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example SPACE
     *
     * @var string
     */
    public $recycleBinScope;

    /**
     * @description This parameter is required.
     *
     * @example scope_id
     *
     * @var string
     */
    public $scopeId;

    /**
     * @description This parameter is required.
     *
     * @example union_id
     *
     * @var string
     */
    public $unionId;
    protected $_name = [
        'recycleBinScope' => 'recycleBinScope',
        'scopeId' => 'scopeId',
        'unionId' => 'unionId',
    ];

    public function validate() {}

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
