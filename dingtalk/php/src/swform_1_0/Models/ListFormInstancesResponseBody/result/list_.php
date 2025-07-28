<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vswform_1_0\Models\ListFormInstancesResponseBody\result;

use AlibabaCloud\SDK\Dingtalk\Vswform_1_0\Models\ListFormInstancesResponseBody\result\list_\forms;
use AlibabaCloud\Tea\Model;

class list_ extends Model
{
    /**
     * @description Use the UTC time format: yyyy-MM-ddTHH:mmZ
     *
     * @example 2022-07-27T18:53Z
     *
     * @var string
     */
    public $createTime;

    /**
     * @example PROC-E5BD2166-B6F4-xxxx
     *
     * @var string
     */
    public $formCode;

    /**
     * @example 11125769-fxxxx
     *
     * @var string
     */
    public $formInstanceId;

    /**
     * @var forms[]
     */
    public $forms;

    /**
     * @description Use the UTC time format: yyyy-MM-ddTHH:mmZ
     *
     * @example 2022-07-27T18:53Z
     *
     * @var string
     */
    public $modifyTime;

    /**
     * @example 1
     *
     * @var string
     */
    public $studentClassId;

    /**
     * @example 三年二班
     *
     * @var string
     */
    public $studentClassName;

    /**
     * @example 钉三多
     *
     * @var string
     */
    public $studentName;

    /**
     * @example 1
     *
     * @var string
     */
    public $studentUserId;

    /**
     * @example user123
     *
     * @var string
     */
    public $submitterUserId;

    /**
     * @example 钉三多
     *
     * @var string
     */
    public $submitterUserName;

    /**
     * @example 智能填表测试
     *
     * @var string
     */
    public $title;
    protected $_name = [
        'createTime' => 'createTime',
        'formCode' => 'formCode',
        'formInstanceId' => 'formInstanceId',
        'forms' => 'forms',
        'modifyTime' => 'modifyTime',
        'studentClassId' => 'studentClassId',
        'studentClassName' => 'studentClassName',
        'studentName' => 'studentName',
        'studentUserId' => 'studentUserId',
        'submitterUserId' => 'submitterUserId',
        'submitterUserName' => 'submitterUserName',
        'title' => 'title',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->createTime) {
            $res['createTime'] = $this->createTime;
        }
        if (null !== $this->formCode) {
            $res['formCode'] = $this->formCode;
        }
        if (null !== $this->formInstanceId) {
            $res['formInstanceId'] = $this->formInstanceId;
        }
        if (null !== $this->forms) {
            $res['forms'] = [];
            if (null !== $this->forms && \is_array($this->forms)) {
                $n = 0;
                foreach ($this->forms as $item) {
                    $res['forms'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->modifyTime) {
            $res['modifyTime'] = $this->modifyTime;
        }
        if (null !== $this->studentClassId) {
            $res['studentClassId'] = $this->studentClassId;
        }
        if (null !== $this->studentClassName) {
            $res['studentClassName'] = $this->studentClassName;
        }
        if (null !== $this->studentName) {
            $res['studentName'] = $this->studentName;
        }
        if (null !== $this->studentUserId) {
            $res['studentUserId'] = $this->studentUserId;
        }
        if (null !== $this->submitterUserId) {
            $res['submitterUserId'] = $this->submitterUserId;
        }
        if (null !== $this->submitterUserName) {
            $res['submitterUserName'] = $this->submitterUserName;
        }
        if (null !== $this->title) {
            $res['title'] = $this->title;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return list_
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['createTime'])) {
            $model->createTime = $map['createTime'];
        }
        if (isset($map['formCode'])) {
            $model->formCode = $map['formCode'];
        }
        if (isset($map['formInstanceId'])) {
            $model->formInstanceId = $map['formInstanceId'];
        }
        if (isset($map['forms'])) {
            if (!empty($map['forms'])) {
                $model->forms = [];
                $n = 0;
                foreach ($map['forms'] as $item) {
                    $model->forms[$n++] = null !== $item ? forms::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['modifyTime'])) {
            $model->modifyTime = $map['modifyTime'];
        }
        if (isset($map['studentClassId'])) {
            $model->studentClassId = $map['studentClassId'];
        }
        if (isset($map['studentClassName'])) {
            $model->studentClassName = $map['studentClassName'];
        }
        if (isset($map['studentName'])) {
            $model->studentName = $map['studentName'];
        }
        if (isset($map['studentUserId'])) {
            $model->studentUserId = $map['studentUserId'];
        }
        if (isset($map['submitterUserId'])) {
            $model->submitterUserId = $map['submitterUserId'];
        }
        if (isset($map['submitterUserName'])) {
            $model->submitterUserName = $map['submitterUserName'];
        }
        if (isset($map['title'])) {
            $model->title = $map['title'];
        }

        return $model;
    }
}
