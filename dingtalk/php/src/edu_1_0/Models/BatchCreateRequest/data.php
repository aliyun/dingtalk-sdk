<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\BatchCreateRequest;

use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\BatchCreateRequest\data\cardRuleItemParamList;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\BatchCreateRequest\data\orgClassStudentGroupList;
use AlibabaCloud\Tea\Model;

class data extends Model
{
    /**
     * @example true
     *
     * @var bool
     */
    public $canReissueCard;

    /**
     * @example 3
     *
     * @var int
     */
    public $cardCycle;

    /**
     * @description This parameter is required.
     *
     * @var int[]
     */
    public $cardFrequency;

    /**
     * @description This parameter is required.
     *
     * @var cardRuleItemParamList[]
     */
    public $cardRuleItemParamList;

    /**
     * @var string[]
     */
    public $classIds;

    /**
     * @var string[]
     */
    public $classNames;

    /**
     * @description This parameter is required.
     *
     * @example 打卡的内容
     *
     * @var string
     */
    public $content;

    /**
     * @var int
     */
    public $effectDate;

    /**
     * @var string
     */
    public $medias;

    /**
     * @var string
     */
    public $needMetering;

    /**
     * @description This parameter is required.
     *
     * @var orgClassStudentGroupList[]
     */
    public $orgClassStudentGroupList;

    /**
     * @description This parameter is required.
     *
     * @var int
     */
    public $remindHour;

    /**
     * @description This parameter is required.
     *
     * @var int
     */
    public $remindMinute;

    /**
     * @var string
     */
    public $targetRole;

    /**
     * @var int
     */
    public $templateId;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $title;

    /**
     * @var string
     */
    public $unitOfMeasurement;
    protected $_name = [
        'canReissueCard'           => 'canReissueCard',
        'cardCycle'                => 'cardCycle',
        'cardFrequency'            => 'cardFrequency',
        'cardRuleItemParamList'    => 'cardRuleItemParamList',
        'classIds'                 => 'classIds',
        'classNames'               => 'classNames',
        'content'                  => 'content',
        'effectDate'               => 'effectDate',
        'medias'                   => 'medias',
        'needMetering'             => 'needMetering',
        'orgClassStudentGroupList' => 'orgClassStudentGroupList',
        'remindHour'               => 'remindHour',
        'remindMinute'             => 'remindMinute',
        'targetRole'               => 'targetRole',
        'templateId'               => 'templateId',
        'title'                    => 'title',
        'unitOfMeasurement'        => 'unitOfMeasurement',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->canReissueCard) {
            $res['canReissueCard'] = $this->canReissueCard;
        }
        if (null !== $this->cardCycle) {
            $res['cardCycle'] = $this->cardCycle;
        }
        if (null !== $this->cardFrequency) {
            $res['cardFrequency'] = $this->cardFrequency;
        }
        if (null !== $this->cardRuleItemParamList) {
            $res['cardRuleItemParamList'] = [];
            if (null !== $this->cardRuleItemParamList && \is_array($this->cardRuleItemParamList)) {
                $n = 0;
                foreach ($this->cardRuleItemParamList as $item) {
                    $res['cardRuleItemParamList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->classIds) {
            $res['classIds'] = $this->classIds;
        }
        if (null !== $this->classNames) {
            $res['classNames'] = $this->classNames;
        }
        if (null !== $this->content) {
            $res['content'] = $this->content;
        }
        if (null !== $this->effectDate) {
            $res['effectDate'] = $this->effectDate;
        }
        if (null !== $this->medias) {
            $res['medias'] = $this->medias;
        }
        if (null !== $this->needMetering) {
            $res['needMetering'] = $this->needMetering;
        }
        if (null !== $this->orgClassStudentGroupList) {
            $res['orgClassStudentGroupList'] = [];
            if (null !== $this->orgClassStudentGroupList && \is_array($this->orgClassStudentGroupList)) {
                $n = 0;
                foreach ($this->orgClassStudentGroupList as $item) {
                    $res['orgClassStudentGroupList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->remindHour) {
            $res['remindHour'] = $this->remindHour;
        }
        if (null !== $this->remindMinute) {
            $res['remindMinute'] = $this->remindMinute;
        }
        if (null !== $this->targetRole) {
            $res['targetRole'] = $this->targetRole;
        }
        if (null !== $this->templateId) {
            $res['templateId'] = $this->templateId;
        }
        if (null !== $this->title) {
            $res['title'] = $this->title;
        }
        if (null !== $this->unitOfMeasurement) {
            $res['unitOfMeasurement'] = $this->unitOfMeasurement;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return data
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['canReissueCard'])) {
            $model->canReissueCard = $map['canReissueCard'];
        }
        if (isset($map['cardCycle'])) {
            $model->cardCycle = $map['cardCycle'];
        }
        if (isset($map['cardFrequency'])) {
            if (!empty($map['cardFrequency'])) {
                $model->cardFrequency = $map['cardFrequency'];
            }
        }
        if (isset($map['cardRuleItemParamList'])) {
            if (!empty($map['cardRuleItemParamList'])) {
                $model->cardRuleItemParamList = [];
                $n                            = 0;
                foreach ($map['cardRuleItemParamList'] as $item) {
                    $model->cardRuleItemParamList[$n++] = null !== $item ? cardRuleItemParamList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['classIds'])) {
            if (!empty($map['classIds'])) {
                $model->classIds = $map['classIds'];
            }
        }
        if (isset($map['classNames'])) {
            if (!empty($map['classNames'])) {
                $model->classNames = $map['classNames'];
            }
        }
        if (isset($map['content'])) {
            $model->content = $map['content'];
        }
        if (isset($map['effectDate'])) {
            $model->effectDate = $map['effectDate'];
        }
        if (isset($map['medias'])) {
            $model->medias = $map['medias'];
        }
        if (isset($map['needMetering'])) {
            $model->needMetering = $map['needMetering'];
        }
        if (isset($map['orgClassStudentGroupList'])) {
            if (!empty($map['orgClassStudentGroupList'])) {
                $model->orgClassStudentGroupList = [];
                $n                               = 0;
                foreach ($map['orgClassStudentGroupList'] as $item) {
                    $model->orgClassStudentGroupList[$n++] = null !== $item ? orgClassStudentGroupList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['remindHour'])) {
            $model->remindHour = $map['remindHour'];
        }
        if (isset($map['remindMinute'])) {
            $model->remindMinute = $map['remindMinute'];
        }
        if (isset($map['targetRole'])) {
            $model->targetRole = $map['targetRole'];
        }
        if (isset($map['templateId'])) {
            $model->templateId = $map['templateId'];
        }
        if (isset($map['title'])) {
            $model->title = $map['title'];
        }
        if (isset($map['unitOfMeasurement'])) {
            $model->unitOfMeasurement = $map['unitOfMeasurement'];
        }

        return $model;
    }
}
