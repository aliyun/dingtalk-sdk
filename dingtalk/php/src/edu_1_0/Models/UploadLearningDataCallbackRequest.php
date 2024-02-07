<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\Tea\Model;

class UploadLearningDataCallbackRequest extends Model
{
    /**
     * @example 1
     *
     * @var string
     */
    public $bizId;

    /**
     * @example HOMEWORK
     *
     * @var string
     */
    public $bizType;

    /**
     * @example dingxxxxxxxxxxxxxxxxxxxx
     *
     * @var string
     */
    public $corpId;

    /**
     * @example 1
     *
     * @var int
     */
    public $deptId;

    /**
     * @example 1672502400000
     *
     * @var int
     */
    public $generatedTime;

    /**
     * @example 0123456
     *
     * @var string
     */
    public $studentUserId;

    /**
     * @example shuxue
     *
     * @var string
     */
    public $subjectCode;
    protected $_name = [
        'bizId'         => 'bizId',
        'bizType'       => 'bizType',
        'corpId'        => 'corpId',
        'deptId'        => 'deptId',
        'generatedTime' => 'generatedTime',
        'studentUserId' => 'studentUserId',
        'subjectCode'   => 'subjectCode',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->bizId) {
            $res['bizId'] = $this->bizId;
        }
        if (null !== $this->bizType) {
            $res['bizType'] = $this->bizType;
        }
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->deptId) {
            $res['deptId'] = $this->deptId;
        }
        if (null !== $this->generatedTime) {
            $res['generatedTime'] = $this->generatedTime;
        }
        if (null !== $this->studentUserId) {
            $res['studentUserId'] = $this->studentUserId;
        }
        if (null !== $this->subjectCode) {
            $res['subjectCode'] = $this->subjectCode;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UploadLearningDataCallbackRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['bizId'])) {
            $model->bizId = $map['bizId'];
        }
        if (isset($map['bizType'])) {
            $model->bizType = $map['bizType'];
        }
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['deptId'])) {
            $model->deptId = $map['deptId'];
        }
        if (isset($map['generatedTime'])) {
            $model->generatedTime = $map['generatedTime'];
        }
        if (isset($map['studentUserId'])) {
            $model->studentUserId = $map['studentUserId'];
        }
        if (isset($map['subjectCode'])) {
            $model->subjectCode = $map['subjectCode'];
        }

        return $model;
    }
}
