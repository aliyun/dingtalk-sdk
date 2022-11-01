<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vlink_1_0\Models;

use AlibabaCloud\Tea\Model;

class ListFollowerRequest extends Model
{
    /**
     * @description 服务窗帐号ID，用于服务窗归属组织下应用AK(非服务窗自建应用)指定服务窗帐号。
     * 帐号ID可以通过服务窗帐号查询接口获取。
     * @var string
     */
    public $accountId;

    /**
     * @description 分页查询页大小。
     *
     * @var int
     */
    public $maxResults;

    /**
     * @description 分页查询下一页token,首页查询此字段可空，其它页查询时需要将此值设置炎上一次接口调用的token
     *
     * @var string
     */
    public $nextToken;
    protected $_name = [
        'accountId'  => 'accountId',
        'maxResults' => 'maxResults',
        'nextToken'  => 'nextToken',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->accountId) {
            $res['accountId'] = $this->accountId;
        }
        if (null !== $this->maxResults) {
            $res['maxResults'] = $this->maxResults;
        }
        if (null !== $this->nextToken) {
            $res['nextToken'] = $this->nextToken;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ListFollowerRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['accountId'])) {
            $model->accountId = $map['accountId'];
        }
        if (isset($map['maxResults'])) {
            $model->maxResults = $map['maxResults'];
        }
        if (isset($map['nextToken'])) {
            $model->nextToken = $map['nextToken'];
        }

        return $model;
    }
}
