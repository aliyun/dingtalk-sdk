<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryOrgCorrectTaskWithWrongQuestionResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryOrgCorrectTaskWithWrongQuestionResponseBody\result\studentWrongQuestions;
use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @var int
     */
    public $classId;

    /**
     * @var string
     */
    public $className;

    /**
     * @var string
     */
    public $corpId;

    /**
     * @var string
     */
    public $correctedPdfUrl;

    /**
     * @var int
     */
    public $createTime;

    /**
     * @var mixed[]
     */
    public $extInfo;

    /**
     * @var string
     */
    public $gradeName;

    /**
     * @var string
     */
    public $paperName;

    /**
     * @var string
     */
    public $scannedPdfUrl;

    /**
     * @var studentWrongQuestions[]
     */
    public $studentWrongQuestions;

    /**
     * @var int
     */
    public $submitTime;

    /**
     * @var string
     */
    public $taskCode;

    /**
     * @var string
     */
    public $teacherId;

    /**
     * @var string
     */
    public $teacherPdfUrl;
    protected $_name = [
        'classId' => 'classId',
        'className' => 'className',
        'corpId' => 'corpId',
        'correctedPdfUrl' => 'correctedPdfUrl',
        'createTime' => 'createTime',
        'extInfo' => 'extInfo',
        'gradeName' => 'gradeName',
        'paperName' => 'paperName',
        'scannedPdfUrl' => 'scannedPdfUrl',
        'studentWrongQuestions' => 'studentWrongQuestions',
        'submitTime' => 'submitTime',
        'taskCode' => 'taskCode',
        'teacherId' => 'teacherId',
        'teacherPdfUrl' => 'teacherPdfUrl',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->classId) {
            $res['classId'] = $this->classId;
        }
        if (null !== $this->className) {
            $res['className'] = $this->className;
        }
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->correctedPdfUrl) {
            $res['correctedPdfUrl'] = $this->correctedPdfUrl;
        }
        if (null !== $this->createTime) {
            $res['createTime'] = $this->createTime;
        }
        if (null !== $this->extInfo) {
            $res['extInfo'] = $this->extInfo;
        }
        if (null !== $this->gradeName) {
            $res['gradeName'] = $this->gradeName;
        }
        if (null !== $this->paperName) {
            $res['paperName'] = $this->paperName;
        }
        if (null !== $this->scannedPdfUrl) {
            $res['scannedPdfUrl'] = $this->scannedPdfUrl;
        }
        if (null !== $this->studentWrongQuestions) {
            $res['studentWrongQuestions'] = [];
            if (null !== $this->studentWrongQuestions && \is_array($this->studentWrongQuestions)) {
                $n = 0;
                foreach ($this->studentWrongQuestions as $item) {
                    $res['studentWrongQuestions'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->submitTime) {
            $res['submitTime'] = $this->submitTime;
        }
        if (null !== $this->taskCode) {
            $res['taskCode'] = $this->taskCode;
        }
        if (null !== $this->teacherId) {
            $res['teacherId'] = $this->teacherId;
        }
        if (null !== $this->teacherPdfUrl) {
            $res['teacherPdfUrl'] = $this->teacherPdfUrl;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return result
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['classId'])) {
            $model->classId = $map['classId'];
        }
        if (isset($map['className'])) {
            $model->className = $map['className'];
        }
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['correctedPdfUrl'])) {
            $model->correctedPdfUrl = $map['correctedPdfUrl'];
        }
        if (isset($map['createTime'])) {
            $model->createTime = $map['createTime'];
        }
        if (isset($map['extInfo'])) {
            $model->extInfo = $map['extInfo'];
        }
        if (isset($map['gradeName'])) {
            $model->gradeName = $map['gradeName'];
        }
        if (isset($map['paperName'])) {
            $model->paperName = $map['paperName'];
        }
        if (isset($map['scannedPdfUrl'])) {
            $model->scannedPdfUrl = $map['scannedPdfUrl'];
        }
        if (isset($map['studentWrongQuestions'])) {
            if (!empty($map['studentWrongQuestions'])) {
                $model->studentWrongQuestions = [];
                $n = 0;
                foreach ($map['studentWrongQuestions'] as $item) {
                    $model->studentWrongQuestions[$n++] = null !== $item ? studentWrongQuestions::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['submitTime'])) {
            $model->submitTime = $map['submitTime'];
        }
        if (isset($map['taskCode'])) {
            $model->taskCode = $map['taskCode'];
        }
        if (isset($map['teacherId'])) {
            $model->teacherId = $map['teacherId'];
        }
        if (isset($map['teacherPdfUrl'])) {
            $model->teacherPdfUrl = $map['teacherPdfUrl'];
        }

        return $model;
    }
}
