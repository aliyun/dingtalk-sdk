<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\FormCreateRequest;

use AlibabaCloud\Tea\Model;

class templateConfig extends Model
{
    /**
     * @example abcd
     *
     * @var string
     */
    public $dirId;

    /**
     * @example true
     *
     * @var bool
     */
    public $disableDeleteProcess;

    /**
     * @example true
     *
     * @var bool
     */
    public $disableFormEdit;

    /**
     * @example true
     *
     * @var bool
     */
    public $disableHomepage;

    /**
     * @example true
     *
     * @var bool
     */
    public $disableResubmit;

    /**
     * @example true
     *
     * @var bool
     */
    public $disableStopProcessButton;

    /**
     * @example true
     *
     * @var bool
     */
    public $hidden;

    /**
     * @example efgh
     *
     * @var string
     */
    public $originDirId;
    protected $_name = [
        'dirId' => 'dirId',
        'disableDeleteProcess' => 'disableDeleteProcess',
        'disableFormEdit' => 'disableFormEdit',
        'disableHomepage' => 'disableHomepage',
        'disableResubmit' => 'disableResubmit',
        'disableStopProcessButton' => 'disableStopProcessButton',
        'hidden' => 'hidden',
        'originDirId' => 'originDirId',
    ];

    public function validate() {}

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
