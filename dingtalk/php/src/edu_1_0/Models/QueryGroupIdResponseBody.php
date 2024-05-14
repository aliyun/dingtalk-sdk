<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryGroupIdResponseBody extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example dingding123
     *
     * @var string
     */
    public $corpId;

    /**
     * @description This parameter is required.
     *
     * @example NTK300001
     *
     * @var string
     */
    public $groupId;

    /**
     * @description This parameter is required.
     *
     * @example 200001
     *
     * @var string
     */
    public $merchantId;

    /**
     * @description This parameter is required.
     *
     * @example 某某商户
     *
     * @var string
     */
    public $merchantName;

    /**
     * @description This parameter is required.
     *
     * @example 阿里云教育
     *
     * @var string
     */
    public $name;

    /**
     * @description This parameter is required.
     *
     * @example 100001
     *
     * @var string
     */
    public $pid;
    protected $_name = [
        'corpId'       => 'corpId',
        'groupId'      => 'groupId',
        'merchantId'   => 'merchantId',
        'merchantName' => 'merchantName',
        'name'         => 'name',
        'pid'          => 'pid',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->groupId) {
            $res['groupId'] = $this->groupId;
        }
        if (null !== $this->merchantId) {
            $res['merchantId'] = $this->merchantId;
        }
        if (null !== $this->merchantName) {
            $res['merchantName'] = $this->merchantName;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->pid) {
            $res['pid'] = $this->pid;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryGroupIdResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['groupId'])) {
            $model->groupId = $map['groupId'];
        }
        if (isset($map['merchantId'])) {
            $model->merchantId = $map['merchantId'];
        }
        if (isset($map['merchantName'])) {
            $model->merchantName = $map['merchantName'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['pid'])) {
            $model->pid = $map['pid'];
        }

        return $model;
    }
}
