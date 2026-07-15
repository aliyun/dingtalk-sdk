<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\Tea\Model;

class CardSubmitCardRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example industry_center
     *
     * @var string
     */
    public $cardBizCode;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $cardBizId;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $cardId;

    /**
     * @var string
     */
    public $cardTaskCode;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $cardTaskId;

    /**
     * @var string
     */
    public $content;

    /**
     * @var string
     */
    public $detailUrl;

    /**
     * @var string
     */
    public $editUrl;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $medias;

    /**
     * @var float
     */
    public $meteringNumber;

    /**
     * @var bool
     */
    public $reissueCard;

    /**
     * @var string
     */
    public $resultEvaluation;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $sourceType;

    /**
     * @var string
     */
    public $specifiedStudentId;

    /**
     * @var string
     */
    public $unitOfMeasurement;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'cardBizCode' => 'cardBizCode',
        'cardBizId' => 'cardBizId',
        'cardId' => 'cardId',
        'cardTaskCode' => 'cardTaskCode',
        'cardTaskId' => 'cardTaskId',
        'content' => 'content',
        'detailUrl' => 'detailUrl',
        'editUrl' => 'editUrl',
        'medias' => 'medias',
        'meteringNumber' => 'meteringNumber',
        'reissueCard' => 'reissueCard',
        'resultEvaluation' => 'resultEvaluation',
        'sourceType' => 'sourceType',
        'specifiedStudentId' => 'specifiedStudentId',
        'unitOfMeasurement' => 'unitOfMeasurement',
        'userId' => 'userId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->cardBizCode) {
            $res['cardBizCode'] = $this->cardBizCode;
        }
        if (null !== $this->cardBizId) {
            $res['cardBizId'] = $this->cardBizId;
        }
        if (null !== $this->cardId) {
            $res['cardId'] = $this->cardId;
        }
        if (null !== $this->cardTaskCode) {
            $res['cardTaskCode'] = $this->cardTaskCode;
        }
        if (null !== $this->cardTaskId) {
            $res['cardTaskId'] = $this->cardTaskId;
        }
        if (null !== $this->content) {
            $res['content'] = $this->content;
        }
        if (null !== $this->detailUrl) {
            $res['detailUrl'] = $this->detailUrl;
        }
        if (null !== $this->editUrl) {
            $res['editUrl'] = $this->editUrl;
        }
        if (null !== $this->medias) {
            $res['medias'] = $this->medias;
        }
        if (null !== $this->meteringNumber) {
            $res['meteringNumber'] = $this->meteringNumber;
        }
        if (null !== $this->reissueCard) {
            $res['reissueCard'] = $this->reissueCard;
        }
        if (null !== $this->resultEvaluation) {
            $res['resultEvaluation'] = $this->resultEvaluation;
        }
        if (null !== $this->sourceType) {
            $res['sourceType'] = $this->sourceType;
        }
        if (null !== $this->specifiedStudentId) {
            $res['specifiedStudentId'] = $this->specifiedStudentId;
        }
        if (null !== $this->unitOfMeasurement) {
            $res['unitOfMeasurement'] = $this->unitOfMeasurement;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CardSubmitCardRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['cardBizCode'])) {
            $model->cardBizCode = $map['cardBizCode'];
        }
        if (isset($map['cardBizId'])) {
            $model->cardBizId = $map['cardBizId'];
        }
        if (isset($map['cardId'])) {
            $model->cardId = $map['cardId'];
        }
        if (isset($map['cardTaskCode'])) {
            $model->cardTaskCode = $map['cardTaskCode'];
        }
        if (isset($map['cardTaskId'])) {
            $model->cardTaskId = $map['cardTaskId'];
        }
        if (isset($map['content'])) {
            $model->content = $map['content'];
        }
        if (isset($map['detailUrl'])) {
            $model->detailUrl = $map['detailUrl'];
        }
        if (isset($map['editUrl'])) {
            $model->editUrl = $map['editUrl'];
        }
        if (isset($map['medias'])) {
            $model->medias = $map['medias'];
        }
        if (isset($map['meteringNumber'])) {
            $model->meteringNumber = $map['meteringNumber'];
        }
        if (isset($map['reissueCard'])) {
            $model->reissueCard = $map['reissueCard'];
        }
        if (isset($map['resultEvaluation'])) {
            $model->resultEvaluation = $map['resultEvaluation'];
        }
        if (isset($map['sourceType'])) {
            $model->sourceType = $map['sourceType'];
        }
        if (isset($map['specifiedStudentId'])) {
            $model->specifiedStudentId = $map['specifiedStudentId'];
        }
        if (isset($map['unitOfMeasurement'])) {
            $model->unitOfMeasurement = $map['unitOfMeasurement'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
