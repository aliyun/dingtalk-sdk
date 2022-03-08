<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\FormCreateRequest;

use AlibabaCloud\Tea\Model;

class templateConfig extends Model
{
    /**
     * @description 更新后模板目录id
     *
     * @var string
     */
    public $dirId;

    /**
     * @description 禁用模板删除按钮
     *
     * @var bool
     */
    public $disableDeleteProcess;

    /**
     * @description 禁用表单编辑
     *
     * @var bool
     */
    public $disableFormEdit;

    /**
     * @description 首页工作台是否可见
     *
     * @var bool
     */
    public $disableHomepage;

    /**
     * @description 禁用再次提交
     *
     * @var bool
     */
    public $disableResubmit;

    /**
     * @description 禁用停止按钮
     *
     * @var bool
     */
    public $disableStopProcessButton;

    /**
     * @description 审批场景内隐藏模板
     *
     * @var bool
     */
    public $hidden;

    /**
     * @description 源模板目录id
     *
     * @var string
     */
    public $originDirId;
    protected $_name = [
        'dirId'                    => 'dirId',
        'disableDeleteProcess'     => 'disableDeleteProcess',
        'disableFormEdit'          => 'disableFormEdit',
        'disableHomepage'          => 'disableHomepage',
        'disableResubmit'          => 'disableResubmit',
        'disableStopProcessButton' => 'disableStopProcessButton',
        'hidden'                   => 'hidden',
        'originDirId'              => 'originDirId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->dirId) {
            $res['dirId'] = $this->dirId;
        }
        if (null !== $this->disableDeleteProcess) {
            $res['disableDeleteProcess'] = $this->disableDeleteProcess;
        }
        if (null !== $this->disableFormEdit) {
            $res['disableFormEdit'] = $this->disableFormEdit;
        }
        if (null !== $this->disableHomepage) {
            $res['disableHomepage'] = $this->disableHomepage;
        }
        if (null !== $this->disableResubmit) {
            $res['disableResubmit'] = $this->disableResubmit;
        }
        if (null !== $this->disableStopProcessButton) {
            $res['disableStopProcessButton'] = $this->disableStopProcessButton;
        }
        if (null !== $this->hidden) {
            $res['hidden'] = $this->hidden;
        }
        if (null !== $this->originDirId) {
            $res['originDirId'] = $this->originDirId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return templateConfig
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['dirId'])) {
            $model->dirId = $map['dirId'];
        }
        if (isset($map['disableDeleteProcess'])) {
            $model->disableDeleteProcess = $map['disableDeleteProcess'];
        }
        if (isset($map['disableFormEdit'])) {
            $model->disableFormEdit = $map['disableFormEdit'];
        }
        if (isset($map['disableHomepage'])) {
            $model->disableHomepage = $map['disableHomepage'];
        }
        if (isset($map['disableResubmit'])) {
            $model->disableResubmit = $map['disableResubmit'];
        }
        if (isset($map['disableStopProcessButton'])) {
            $model->disableStopProcessButton = $map['disableStopProcessButton'];
        }
        if (isset($map['hidden'])) {
            $model->hidden = $map['hidden'];
        }
        if (isset($map['originDirId'])) {
            $model->originDirId = $map['originDirId'];
        }

        return $model;
    }
}
