<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models\QuerySmartDeviceAiSceneByIdResponseBody\agent;

use AlibabaCloud\Tea\Model;

class llmModel extends Model
{
    /**
     * @var string
     */
    public $modelId;

    /**
     * @var string
     */
    public $modelName;
    protected $_name = [
        'modelId' => 'modelId',
        'modelName' => 'modelName',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->modelId) {
            $res['modelId'] = $this->modelId;
        }
        if (null !== $this->modelName) {
            $res['modelName'] = $this->modelName;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return llmModel
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['modelId'])) {
            $model->modelId = $map['modelId'];
        }
        if (isset($map['modelName'])) {
            $model->modelName = $map['modelName'];
        }

        return $model;
    }
}
