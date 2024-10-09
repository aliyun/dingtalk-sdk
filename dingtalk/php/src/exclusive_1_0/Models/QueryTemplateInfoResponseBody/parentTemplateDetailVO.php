<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\QueryTemplateInfoResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\QueryTemplateInfoResponseBody\parentTemplateDetailVO\robotTemplateList;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\QueryTemplateInfoResponseBody\parentTemplateDetailVO\toolbarPluginList;
use AlibabaCloud\Tea\Model;

class parentTemplateDetailVO extends Model
{
    /**
     * @var robotTemplateList[]
     */
    public $robotTemplateList;

    /**
     * @var string
     */
    public $templateId;

    /**
     * @var toolbarPluginList[]
     */
    public $toolbarPluginList;
    protected $_name = [
        'robotTemplateList' => 'robotTemplateList',
        'templateId'        => 'templateId',
        'toolbarPluginList' => 'toolbarPluginList',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->robotTemplateList) {
            $res['robotTemplateList'] = [];
            if (null !== $this->robotTemplateList && \is_array($this->robotTemplateList)) {
                $n = 0;
                foreach ($this->robotTemplateList as $item) {
                    $res['robotTemplateList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->templateId) {
            $res['templateId'] = $this->templateId;
        }
        if (null !== $this->toolbarPluginList) {
            $res['toolbarPluginList'] = [];
            if (null !== $this->toolbarPluginList && \is_array($this->toolbarPluginList)) {
                $n = 0;
                foreach ($this->toolbarPluginList as $item) {
                    $res['toolbarPluginList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return parentTemplateDetailVO
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['robotTemplateList'])) {
            if (!empty($map['robotTemplateList'])) {
                $model->robotTemplateList = [];
                $n                        = 0;
                foreach ($map['robotTemplateList'] as $item) {
                    $model->robotTemplateList[$n++] = null !== $item ? robotTemplateList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['templateId'])) {
            $model->templateId = $map['templateId'];
        }
        if (isset($map['toolbarPluginList'])) {
            if (!empty($map['toolbarPluginList'])) {
                $model->toolbarPluginList = [];
                $n                        = 0;
                foreach ($map['toolbarPluginList'] as $item) {
                    $model->toolbarPluginList[$n++] = null !== $item ? toolbarPluginList::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
