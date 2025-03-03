<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\AddEvaluatePerformanceRequest;

use AlibabaCloud\Tea\Model;

class evaluationData extends Model
{
    /**
     * @var string
     */
    public $evaluationContent;

    /**
     * @var string
     */
    public $eventTime;

    /**
     * @var string
     */
    public $id;

    /**
     * @var string
     */
    public $studentId;

    /**
     * @var string
     */
    public $teacherId;
    protected $_name = [
        'evaluationContent' => 'evaluationContent',
        'eventTime'         => 'eventTime',
        'id'                => 'id',
        'studentId'         => 'studentId',
        'teacherId'         => 'teacherId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->evaluationContent) {
            $res['evaluationContent'] = $this->evaluationContent;
        }
        if (null !== $this->eventTime) {
            $res['eventTime'] = $this->eventTime;
        }
        if (null !== $this->id) {
            $res['id'] = $this->id;
        }
        if (null !== $this->studentId) {
            $res['studentId'] = $this->studentId;
        }
        if (null !== $this->teacherId) {
            $res['teacherId'] = $this->teacherId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return evaluationData
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['evaluationContent'])) {
            $model->evaluationContent = $map['evaluationContent'];
        }
        if (isset($map['eventTime'])) {
            $model->eventTime = $map['eventTime'];
        }
        if (isset($map['id'])) {
            $model->id = $map['id'];
        }
        if (isset($map['studentId'])) {
            $model->studentId = $map['studentId'];
        }
        if (isset($map['teacherId'])) {
            $model->teacherId = $map['teacherId'];
        }

        return $model;
    }
}
