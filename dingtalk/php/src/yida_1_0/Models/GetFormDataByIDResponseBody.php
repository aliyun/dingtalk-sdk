<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetFormDataByIDResponseBody\originator;
use AlibabaCloud\Tea\Model;

class GetFormDataByIDResponseBody extends Model
{
    /**
     * @description 表单数据详情
     *
     * @var mixed[]
     */
    public $formData;

    /**
     * @description 表单实例ID
     *
     * @var string
     */
    public $formInstId;

    /**
     * @description 表单ID
     *
     * @var string
     */
    public $formUuid;

    /**
     * @description 最后修改时间
     *
     * @var string
     */
    public $modifiedTimeGMT;

    /**
     * @description 发起人详情
     *
     * @var originator
     */
    public $originator;
    protected $_name = [
        'formData'        => 'formData',
        'formInstId'      => 'formInstId',
        'formUuid'        => 'formUuid',
        'modifiedTimeGMT' => 'modifiedTimeGMT',
        'originator'      => 'originator',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->formData) {
            $res['formData'] = $this->formData;
        }
        if (null !== $this->formInstId) {
            $res['formInstId'] = $this->formInstId;
        }
        if (null !== $this->formUuid) {
            $res['formUuid'] = $this->formUuid;
        }
        if (null !== $this->modifiedTimeGMT) {
            $res['modifiedTimeGMT'] = $this->modifiedTimeGMT;
        }
        if (null !== $this->originator) {
            $res['originator'] = null !== $this->originator ? $this->originator->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetFormDataByIDResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['formData'])) {
            $model->formData = $map['formData'];
        }
        if (isset($map['formInstId'])) {
            $model->formInstId = $map['formInstId'];
        }
        if (isset($map['formUuid'])) {
            $model->formUuid = $map['formUuid'];
        }
        if (isset($map['modifiedTimeGMT'])) {
            $model->modifiedTimeGMT = $map['modifiedTimeGMT'];
        }
        if (isset($map['originator'])) {
            $model->originator = originator::fromMap($map['originator']);
        }

        return $model;
    }
}
