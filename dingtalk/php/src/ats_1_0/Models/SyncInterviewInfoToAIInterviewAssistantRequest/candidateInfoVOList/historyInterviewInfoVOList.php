<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vats_1_0\Models\SyncInterviewInfoToAIInterviewAssistantRequest\candidateInfoVOList;

use AlibabaCloud\SDK\Dingtalk\Vats_1_0\Models\SyncInterviewInfoToAIInterviewAssistantRequest\candidateInfoVOList\historyInterviewInfoVOList\aiInterviewHistoryEvaluationContentList;
use AlibabaCloud\Tea\Model;

class historyInterviewInfoVOList extends Model
{
    /**
     * @var aiInterviewHistoryEvaluationContentList[]
     */
    public $aiInterviewHistoryEvaluationContentList;

    /**
     * @var string[]
     */
    public $canViewUserIdList;

    /**
     * @var string
     */
    public $historyInterviewId;

    /**
     * @var string
     */
    public $historyInterviewRounds;
    protected $_name = [
        'aiInterviewHistoryEvaluationContentList' => 'aiInterviewHistoryEvaluationContentList',
        'canViewUserIdList' => 'canViewUserIdList',
        'historyInterviewId' => 'historyInterviewId',
        'historyInterviewRounds' => 'historyInterviewRounds',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->aiInterviewHistoryEvaluationContentList) {
            $res['aiInterviewHistoryEvaluationContentList'] = [];
            if (null !== $this->aiInterviewHistoryEvaluationContentList && \is_array($this->aiInterviewHistoryEvaluationContentList)) {
                $n = 0;
                foreach ($this->aiInterviewHistoryEvaluationContentList as $item) {
                    $res['aiInterviewHistoryEvaluationContentList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->canViewUserIdList) {
            $res['canViewUserIdList'] = $this->canViewUserIdList;
        }
        if (null !== $this->historyInterviewId) {
            $res['historyInterviewId'] = $this->historyInterviewId;
        }
        if (null !== $this->historyInterviewRounds) {
            $res['historyInterviewRounds'] = $this->historyInterviewRounds;
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
        if (isset($map['aiInterviewHistoryEvaluationContentList'])) {
            if (!empty($map['aiInterviewHistoryEvaluationContentList'])) {
                $model->aiInterviewHistoryEvaluationContentList = [];
                $n = 0;
                foreach ($map['aiInterviewHistoryEvaluationContentList'] as $item) {
                    $model->aiInterviewHistoryEvaluationContentList[$n++] = null !== $item ? aiInterviewHistoryEvaluationContentList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['canViewUserIdList'])) {
            if (!empty($map['canViewUserIdList'])) {
                $model->canViewUserIdList = $map['canViewUserIdList'];
            }
        }
        if (isset($map['historyInterviewId'])) {
            $model->historyInterviewId = $map['historyInterviewId'];
        }
        if (isset($map['historyInterviewRounds'])) {
            $model->historyInterviewRounds = $map['historyInterviewRounds'];
        }

        return $model;
    }
}
