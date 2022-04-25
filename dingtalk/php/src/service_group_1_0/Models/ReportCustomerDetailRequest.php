<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models;

use AlibabaCloud\Tea\Model;

class ReportCustomerDetailRequest extends Model
{
    /**
     * @description 是否登录钉钉
     *
     * @var bool
     */
    public $hasLogin;

    /**
     * @description 是否打开群
     *
     * @var bool
     */
    public $hasOpenConv;

    /**
     * @description 截止日期
     *
     * @var string
     */
    public $maxDt;

    /**
     * @description 起始日期
     *
     * @var string
     */
    public $minDt;

    /**
     * @description 开放群id
     *
     * @var string
     */
    public $openConversationId;

    /**
     * @description 开发团队ID
     *
     * @var string
     */
    public $openTeamId;

    /**
     * @description 页码
     *
     * @var int
     */
    public $pageNumber;

    /**
     * @description 每页大小
     *
     * @var int
     */
    public $pageSize;
    protected $_name = [
        'hasLogin'           => 'hasLogin',
        'hasOpenConv'        => 'hasOpenConv',
        'maxDt'              => 'maxDt',
        'minDt'              => 'minDt',
        'openConversationId' => 'openConversationId',
        'openTeamId'         => 'openTeamId',
        'pageNumber'         => 'pageNumber',
        'pageSize'           => 'pageSize',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->hasLogin) {
            $res['hasLogin'] = $this->hasLogin;
        }
        if (null !== $this->hasOpenConv) {
            $res['hasOpenConv'] = $this->hasOpenConv;
        }
        if (null !== $this->maxDt) {
            $res['maxDt'] = $this->maxDt;
        }
        if (null !== $this->minDt) {
            $res['minDt'] = $this->minDt;
        }
        if (null !== $this->openConversationId) {
            $res['openConversationId'] = $this->openConversationId;
        }
        if (null !== $this->openTeamId) {
            $res['openTeamId'] = $this->openTeamId;
        }
        if (null !== $this->pageNumber) {
            $res['pageNumber'] = $this->pageNumber;
        }
        if (null !== $this->pageSize) {
            $res['pageSize'] = $this->pageSize;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ReportCustomerDetailRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['hasLogin'])) {
            $model->hasLogin = $map['hasLogin'];
        }
        if (isset($map['hasOpenConv'])) {
            $model->hasOpenConv = $map['hasOpenConv'];
        }
        if (isset($map['maxDt'])) {
            $model->maxDt = $map['maxDt'];
        }
        if (isset($map['minDt'])) {
            $model->minDt = $map['minDt'];
        }
        if (isset($map['openConversationId'])) {
            $model->openConversationId = $map['openConversationId'];
        }
        if (isset($map['openTeamId'])) {
            $model->openTeamId = $map['openTeamId'];
        }
        if (isset($map['pageNumber'])) {
            $model->pageNumber = $map['pageNumber'];
        }
        if (isset($map['pageSize'])) {
            $model->pageSize = $map['pageSize'];
        }

        return $model;
    }
}
