<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models;

use AlibabaCloud\Tea\Model;

class QuerySmartDeviceAiScenePromptTemplateByIdsRequest extends Model
{
    /**
     * @var string
     */
    public $agentInstanceId;

    /**
     * @var string[]
     */
    public $agentPromptTemplateIds;
    protected $_name = [
        'agentInstanceId' => 'agentInstanceId',
        'agentPromptTemplateIds' => 'agentPromptTemplateIds',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->agentInstanceId) {
            $res['agentInstanceId'] = $this->agentInstanceId;
        }
        if (null !== $this->agentPromptTemplateIds) {
            $res['agentPromptTemplateIds'] = $this->agentPromptTemplateIds;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QuerySmartDeviceAiScenePromptTemplateByIdsRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['agentInstanceId'])) {
            $model->agentInstanceId = $map['agentInstanceId'];
        }
        if (isset($map['agentPromptTemplateIds'])) {
            if (!empty($map['agentPromptTemplateIds'])) {
                $model->agentPromptTemplateIds = $map['agentPromptTemplateIds'];
            }
        }

        return $model;
    }
}
