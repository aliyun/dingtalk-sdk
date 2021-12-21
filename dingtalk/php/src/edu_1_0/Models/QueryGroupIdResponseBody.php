<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryGroupIdResponseBody extends Model
{
    /**
     * @description 开发者pid
     *
     * @var string
     */
    public $pid;

    /**
     * @description 开发者名称
     *
     * @var string
     */
    public $name;

    /**
     * @description 商户id
     *
     * @var string
     */
    public $merchantId;

    /**
     * @description 商户名称
     *
     * @var string
     */
    public $merchantName;

    /**
     * @description 组织id
     *
     * @var string
     */
    public $corpId;

    /**
     * @description 人脸库id
     *
     * @var string
     */
    public $groupId;
    protected $_name = [
        'pid'          => 'pid',
        'name'         => 'name',
        'merchantId'   => 'merchantId',
        'merchantName' => 'merchantName',
        'corpId'       => 'corpId',
        'groupId'      => 'groupId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->pid) {
            $res['pid'] = $this->pid;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->merchantId) {
            $res['merchantId'] = $this->merchantId;
        }
        if (null !== $this->merchantName) {
            $res['merchantName'] = $this->merchantName;
        }
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->groupId) {
            $res['groupId'] = $this->groupId;
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
        if (isset($map['pid'])) {
            $model->pid = $map['pid'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['merchantId'])) {
            $model->merchantId = $map['merchantId'];
        }
        if (isset($map['merchantName'])) {
            $model->merchantName = $map['merchantName'];
        }
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['groupId'])) {
            $model->groupId = $map['groupId'];
        }

        return $model;
    }
}
