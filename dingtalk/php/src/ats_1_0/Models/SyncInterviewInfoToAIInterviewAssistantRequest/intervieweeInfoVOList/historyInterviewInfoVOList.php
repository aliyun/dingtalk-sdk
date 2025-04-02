<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vats_1_0\Models\SyncInterviewInfoToAIInterviewAssistantRequest\intervieweeInfoVOList;

use AlibabaCloud\Tea\Model;

class historyInterviewInfoVOList extends Model
{
    /**
     * @var string[]
     */
    public $canViewUserIdList;

    /**
     * @var string
     */
    public $evaluation;

    /**
     * @var string
     */
    public $historyInterviewId;

    /**
     * @var string
     */
    public $historyInterviewResult;

    /**
     * @var string
     */
    public $interviewRounds;

    /**
     * @var string
     */
    public $interviewerName;
    protected $_name = [
        'canViewUserIdList' => 'canViewUserIdList',
        'evaluation' => 'evaluation',
        'historyInterviewId' => 'historyInterviewId',
        'historyInterviewResult' => 'historyInterviewResult',
        'interviewRounds' => 'interviewRounds',
        'interviewerName' => 'interviewerName',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->canViewUserIdList) {
            $res['canViewUserIdList'] = $this->canViewUserIdList;
        }
        if (null !== $this->evaluation) {
            $res['evaluation'] = $this->evaluation;
        }
        if (null !== $this->historyInterviewId) {
            $res['historyInterviewId'] = $this->historyInterviewId;
        }
        if (null !== $this->historyInterviewResult) {
            $res['historyInterviewResult'] = $this->historyInterviewResult;
        }
        if (null !== $this->interviewRounds) {
            $res['interviewRounds'] = $this->interviewRounds;
        }
        if (null !== $this->interviewerName) {
            $res['interviewerName'] = $this->interviewerName;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return historyInterviewInfoVOList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['canViewUserIdList'])) {
            if (!empty($map['canViewUserIdList'])) {
                $model->canViewUserIdList = $map['canViewUserIdList'];
            }
        }
        if (isset($map['evaluation'])) {
            $model->evaluation = $map['evaluation'];
        }
        if (isset($map['historyInterviewId'])) {
            $model->historyInterviewId = $map['historyInterviewId'];
        }
        if (isset($map['historyInterviewResult'])) {
            $model->historyInterviewResult = $map['historyInterviewResult'];
        }
        if (isset($map['interviewRounds'])) {
            $model->interviewRounds = $map['interviewRounds'];
        }
        if (isset($map['interviewerName'])) {
            $model->interviewerName = $map['interviewerName'];
        }

        return $model;
    }
}
