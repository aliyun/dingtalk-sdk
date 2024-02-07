<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\Tea\Model;

class CardQueryCardFeedsRequest extends Model
{
    /**
     * @example 3
     *
     * @var int
     */
    public $bizType;

    /**
     * @example industry_center
     *
     * @var string
     */
    public $cardBizCode;

    /**
     * @example 856237470
     *
     * @var string
     */
    public $cardBizId;

    /**
     * @example 80264668258
     *
     * @var int
     */
    public $cardId;

    /**
     * @example 5
     *
     * @var int
     */
    public $count;

    /**
     * @var int
     */
    public $cursor;

    /**
     * @example 0
     *
     * @var int
     */
    public $feedType;

    /**
     * @var bool
     */
    public $needFinishProcess;

    /**
     * @example YUFANAI
     *
     * @var string
     */
    public $sourceType;

    /**
     * @example 3000000000847390208
     *
     * @var string
     */
    public $studentId;

    /**
     * @example CARD_TASK_CODE_0
     *
     * @var string
     */
    public $subBizId;

    /**
     * @example manager7741
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'bizType'           => 'bizType',
        'cardBizCode'       => 'cardBizCode',
        'cardBizId'         => 'cardBizId',
        'cardId'            => 'cardId',
        'count'             => 'count',
        'cursor'            => 'cursor',
        'feedType'          => 'feedType',
        'needFinishProcess' => 'needFinishProcess',
        'sourceType'        => 'sourceType',
        'studentId'         => 'studentId',
        'subBizId'          => 'subBizId',
        'userId'            => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->bizType) {
            $res['bizType'] = $this->bizType;
        }
        if (null !== $this->cardBizCode) {
            $res['cardBizCode'] = $this->cardBizCode;
        }
        if (null !== $this->cardBizId) {
            $res['cardBizId'] = $this->cardBizId;
        }
        if (null !== $this->cardId) {
            $res['cardId'] = $this->cardId;
        }
        if (null !== $this->count) {
            $res['count'] = $this->count;
        }
        if (null !== $this->cursor) {
            $res['cursor'] = $this->cursor;
        }
        if (null !== $this->feedType) {
            $res['feedType'] = $this->feedType;
        }
        if (null !== $this->needFinishProcess) {
            $res['needFinishProcess'] = $this->needFinishProcess;
        }
        if (null !== $this->sourceType) {
            $res['sourceType'] = $this->sourceType;
        }
        if (null !== $this->studentId) {
            $res['studentId'] = $this->studentId;
        }
        if (null !== $this->subBizId) {
            $res['subBizId'] = $this->subBizId;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CardQueryCardFeedsRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['bizType'])) {
            $model->bizType = $map['bizType'];
        }
        if (isset($map['cardBizCode'])) {
            $model->cardBizCode = $map['cardBizCode'];
        }
        if (isset($map['cardBizId'])) {
            $model->cardBizId = $map['cardBizId'];
        }
        if (isset($map['cardId'])) {
            $model->cardId = $map['cardId'];
        }
        if (isset($map['count'])) {
            $model->count = $map['count'];
        }
        if (isset($map['cursor'])) {
            $model->cursor = $map['cursor'];
        }
        if (isset($map['feedType'])) {
            $model->feedType = $map['feedType'];
        }
        if (isset($map['needFinishProcess'])) {
            $model->needFinishProcess = $map['needFinishProcess'];
        }
        if (isset($map['sourceType'])) {
            $model->sourceType = $map['sourceType'];
        }
        if (isset($map['studentId'])) {
            $model->studentId = $map['studentId'];
        }
        if (isset($map['subBizId'])) {
            $model->subBizId = $map['subBizId'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
