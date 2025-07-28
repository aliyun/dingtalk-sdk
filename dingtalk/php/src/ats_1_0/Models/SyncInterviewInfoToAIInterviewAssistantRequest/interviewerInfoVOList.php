<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vats_1_0\Models\SyncInterviewInfoToAIInterviewAssistantRequest;

use AlibabaCloud\SDK\Dingtalk\Vats_1_0\Models\SyncInterviewInfoToAIInterviewAssistantRequest\interviewerInfoVOList\interviewEvaluationFormConfigVO;
use AlibabaCloud\Tea\Model;

class interviewerInfoVOList extends Model
{
    /**
     * @var string
     */
    public $id;

    /**
     * @var interviewEvaluationFormConfigVO
     */
    public $interviewEvaluationFormConfigVO;

    /**
     * @var string
     */
    public $name;

    /**
     * @var string
     */
    public $position;
    protected $_name = [
        'id' => 'id',
        'interviewEvaluationFormConfigVO' => 'interviewEvaluationFormConfigVO',
        'name' => 'name',
        'position' => 'position',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->id) {
            $res['id'] = $this->id;
        }
        if (null !== $this->interviewEvaluationFormConfigVO) {
            $res['interviewEvaluationFormConfigVO'] = null !== $this->interviewEvaluationFormConfigVO ? $this->interviewEvaluationFormConfigVO->toMap() : null;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->position) {
            $res['position'] = $this->position;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return interviewerInfoVOList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['id'])) {
            $model->id = $map['id'];
        }
        if (isset($map['interviewEvaluationFormConfigVO'])) {
            $model->interviewEvaluationFormConfigVO = interviewEvaluationFormConfigVO::fromMap($map['interviewEvaluationFormConfigVO']);
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['position'])) {
            $model->position = $map['position'];
        }

        return $model;
    }
}
