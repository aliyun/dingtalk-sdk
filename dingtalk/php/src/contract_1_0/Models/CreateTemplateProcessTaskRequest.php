<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\CreateTemplateProcessTaskRequest\fillData;
use AlibabaCloud\Tea\Model;

class CreateTemplateProcessTaskRequest extends Model
{
    /**
     * @var fillData[]
     */
    public $fillData;

    /**
     * @var string
     */
    public $formId;

    /**
     * @var string
     */
    public $mode;
    protected $_name = [
        'fillData' => 'fillData',
        'formId' => 'formId',
        'mode' => 'mode',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->fillData) {
            $res['fillData'] = [];
            if (null !== $this->fillData && \is_array($this->fillData)) {
                $n = 0;
                foreach ($this->fillData as $item) {
                    $res['fillData'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->formId) {
            $res['formId'] = $this->formId;
        }
        if (null !== $this->mode) {
            $res['mode'] = $this->mode;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreateTemplateProcessTaskRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['fillData'])) {
            if (!empty($map['fillData'])) {
                $model->fillData = [];
                $n = 0;
                foreach ($map['fillData'] as $item) {
                    $model->fillData[$n++] = null !== $item ? fillData::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['formId'])) {
            $model->formId = $map['formId'];
        }
        if (isset($map['mode'])) {
            $model->mode = $map['mode'];
        }

        return $model;
    }
}
