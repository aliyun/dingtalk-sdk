<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vats_1_0\Models\SyncInterviewInfoToAIInterviewAssistantRequest\candidateInfoVOList\historyInterviewInfoVOList;

use AlibabaCloud\Tea\Model;

class aiInterviewHistoryEvaluationContentList extends Model
{
    /**
     * @var string
     */
    public $historyInterviewContent;

    /**
     * @var string
     */
    public $interviewerUserId;
    protected $_name = [
        'historyInterviewContent' => 'historyInterviewContent',
        'interviewerUserId' => 'interviewerUserId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->historyInterviewContent) {
            $res['historyInterviewContent'] = $this->historyInterviewContent;
        }
        if (null !== $this->interviewerUserId) {
            $res['interviewerUserId'] = $this->interviewerUserId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return aiInterviewHistoryEvaluationContentList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['historyInterviewContent'])) {
            $model->historyInterviewContent = $map['historyInterviewContent'];
        }
        if (isset($map['interviewerUserId'])) {
            $model->interviewerUserId = $map['interviewerUserId'];
        }

        return $model;
    }
}
