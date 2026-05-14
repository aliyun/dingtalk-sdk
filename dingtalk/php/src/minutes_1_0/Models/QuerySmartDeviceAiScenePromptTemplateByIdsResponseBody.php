<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models\QuerySmartDeviceAiScenePromptTemplateByIdsResponseBody\agentPromptTemplates;
use AlibabaCloud\Tea\Model;

class QuerySmartDeviceAiScenePromptTemplateByIdsResponseBody extends Model
{
    /**
     * @var agentPromptTemplates[]
     */
    public $agentPromptTemplates;
    protected $_name = [
        'agentPromptTemplates' => 'agentPromptTemplates',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->agentPromptTemplates) {
            $res['agentPromptTemplates'] = [];
            if (null !== $this->agentPromptTemplates && \is_array($this->agentPromptTemplates)) {
                $n = 0;
                foreach ($this->agentPromptTemplates as $item) {
                    $res['agentPromptTemplates'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QuerySmartDeviceAiScenePromptTemplateByIdsResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['agentPromptTemplates'])) {
            if (!empty($map['agentPromptTemplates'])) {
                $model->agentPromptTemplates = [];
                $n = 0;
                foreach ($map['agentPromptTemplates'] as $item) {
                    $model->agentPromptTemplates[$n++] = null !== $item ? agentPromptTemplates::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
