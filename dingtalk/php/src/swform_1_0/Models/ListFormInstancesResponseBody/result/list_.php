<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vswform_1_0\Models\ListFormInstancesResponseBody\result;

use AlibabaCloud\SDK\Dingtalk\Vswform_1_0\Models\ListFormInstancesResponseBody\result\list_\forms;
use AlibabaCloud\Tea\Model;

class list_ extends Model
{
    /**
     * @description 创建时间。iso8601格式。
     *
     * @var string
     */
    public $createTime;

    /**
     * @description 填表code，用此code可调接口获取填表列表。
     *
     * @var string
     */
    public $formCode;

    /**
     * @description 实例ID。
     *
     * @var string
     */
    public $formInstanceId;

    /**
     * @description 表单内容列表。
     *
     * @var forms[]
     */
    public $forms;

    /**
     * @description 更新时间。iso8601格式。
     *
     * @var string
     */
    public $modifyTime;

    /**
     * @description 学生班级ID。
     *
     * @var string
     */
    public $studentClassId;

    /**
     * @description 学生班级名称。
     *
     * @var string
     */
    public $studentClassName;

    /**
     * @description 学生名称。
     *
     * @var string
     */
    public $studentName;

    /**
     * @description 学生ID。
     *
     * @var string
     */
    public $studentUserId;

    /**
     * @description 提交人的userid。
     *
     * @var string
     */
    public $submitterUserId;

    /**
     * @description 提交人姓名。
     *
     * @var string
     */
    public $submitterUserName;

    /**
     * @description 填表名称。
     *
     * @var string
     */
    public $title;
    protected $_name = [
        'createTime'        => 'createTime',
        'formCode'          => 'formCode',
        'formInstanceId'    => 'formInstanceId',
        'forms'             => 'forms',
        'modifyTime'        => 'modifyTime',
        'studentClassId'    => 'studentClassId',
        'studentClassName'  => 'studentClassName',
        'studentName'       => 'studentName',
        'studentUserId'     => 'studentUserId',
        'submitterUserId'   => 'submitterUserId',
        'submitterUserName' => 'submitterUserName',
        'title'             => 'title',
    ];

    public function validate()
    {
    }

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
                $n            = 0;
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
