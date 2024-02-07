<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CardBatchQueryCardsResponseBody\result;

use AlibabaCloud\Tea\Model;

class cards extends Model
{
    /**
     * @example industry_center
     *
     * @var string
     */
    public $cardBizCode;

    /**
     * @example 234234234
     *
     * @var int
     */
    public $cardId;

    /**
     * @example 2
     *
     * @var int
     */
    public $cardStatus;

    /**
     * @example 打卡任务
     *
     * @var string
     */
    public $content;

    /**
     * @example dingdf19b4ee0d73233735c2f4657eb6378f
     *
     * @var string
     */
    public $corpId;

    /**
     * @example 2023-11-16
     *
     * @var string
     */
    public $effectTime;

    /**
     * @var bool
     */
    public $finished;

    /**
     * @example 2023-11-19
     *
     * @var string
     */
    public $gmtCreate;

    /**
     * @example 2023-11-16
     *
     * @var string
     */
    public $optEndTime;

    /**
     * @example 234234234
     *
     * @var string
     */
    public $optEndUserId;

    /**
     * @example 张三
     *
     * @var string
     */
    public $optEndUserName;

    /**
     * @example 2023-11-16
     *
     * @var string
     */
    public $sendTime;

    /**
     * @example 2023-11-16
     *
     * @var string
     */
    public $startTime;

    /**
     * @example 2
     *
     * @var int
     */
    public $status;

    /**
     * @example 23234234
     *
     * @var string
     */
    public $teacherId;

    /**
     * @example 张三
     *
     * @var string
     */
    public $teacherName;

    /**
     * @example 每日锻炼
     *
     * @var string
     */
    public $title;

    /**
     * @example 1
     *
     * @var int
     */
    public $type;
    protected $_name = [
        'cardBizCode'    => 'cardBizCode',
        'cardId'         => 'cardId',
        'cardStatus'     => 'cardStatus',
        'content'        => 'content',
        'corpId'         => 'corpId',
        'effectTime'     => 'effectTime',
        'finished'       => 'finished',
        'gmtCreate'      => 'gmtCreate',
        'optEndTime'     => 'optEndTime',
        'optEndUserId'   => 'optEndUserId',
        'optEndUserName' => 'optEndUserName',
        'sendTime'       => 'sendTime',
        'startTime'      => 'startTime',
        'status'         => 'status',
        'teacherId'      => 'teacherId',
        'teacherName'    => 'teacherName',
        'title'          => 'title',
        'type'           => 'type',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->cardBizCode) {
            $res['cardBizCode'] = $this->cardBizCode;
        }
        if (null !== $this->cardId) {
            $res['cardId'] = $this->cardId;
        }
        if (null !== $this->cardStatus) {
            $res['cardStatus'] = $this->cardStatus;
        }
        if (null !== $this->content) {
            $res['content'] = $this->content;
        }
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->effectTime) {
            $res['effectTime'] = $this->effectTime;
        }
        if (null !== $this->finished) {
            $res['finished'] = $this->finished;
        }
        if (null !== $this->gmtCreate) {
            $res['gmtCreate'] = $this->gmtCreate;
        }
        if (null !== $this->optEndTime) {
            $res['optEndTime'] = $this->optEndTime;
        }
        if (null !== $this->optEndUserId) {
            $res['optEndUserId'] = $this->optEndUserId;
        }
        if (null !== $this->optEndUserName) {
            $res['optEndUserName'] = $this->optEndUserName;
        }
        if (null !== $this->sendTime) {
            $res['sendTime'] = $this->sendTime;
        }
        if (null !== $this->startTime) {
            $res['startTime'] = $this->startTime;
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }
        if (null !== $this->teacherId) {
            $res['teacherId'] = $this->teacherId;
        }
        if (null !== $this->teacherName) {
            $res['teacherName'] = $this->teacherName;
        }
        if (null !== $this->title) {
            $res['title'] = $this->title;
        }
        if (null !== $this->type) {
            $res['type'] = $this->type;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return cards
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['cardBizCode'])) {
            $model->cardBizCode = $map['cardBizCode'];
        }
        if (isset($map['cardId'])) {
            $model->cardId = $map['cardId'];
        }
        if (isset($map['cardStatus'])) {
            $model->cardStatus = $map['cardStatus'];
        }
        if (isset($map['content'])) {
            $model->content = $map['content'];
        }
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['effectTime'])) {
            $model->effectTime = $map['effectTime'];
        }
        if (isset($map['finished'])) {
            $model->finished = $map['finished'];
        }
        if (isset($map['gmtCreate'])) {
            $model->gmtCreate = $map['gmtCreate'];
        }
        if (isset($map['optEndTime'])) {
            $model->optEndTime = $map['optEndTime'];
        }
        if (isset($map['optEndUserId'])) {
            $model->optEndUserId = $map['optEndUserId'];
        }
        if (isset($map['optEndUserName'])) {
            $model->optEndUserName = $map['optEndUserName'];
        }
        if (isset($map['sendTime'])) {
            $model->sendTime = $map['sendTime'];
        }
        if (isset($map['startTime'])) {
            $model->startTime = $map['startTime'];
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }
        if (isset($map['teacherId'])) {
            $model->teacherId = $map['teacherId'];
        }
        if (isset($map['teacherName'])) {
            $model->teacherName = $map['teacherName'];
        }
        if (isset($map['title'])) {
            $model->title = $map['title'];
        }
        if (isset($map['type'])) {
            $model->type = $map['type'];
        }

        return $model;
    }
}
