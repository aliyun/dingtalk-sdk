<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vai_paa_s_1_0\Models\ExecuteAgentResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @var string
     */
    public $executeResult;

    /**
     * @var string
     */
    public $skillId;
    protected $_name = [
        'executeResult' => 'executeResult',
        'skillId'       => 'skillId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->executeResult) {
            $res['executeResult'] = $this->executeResult;
        }
        if (null !== $this->skillId) {
            $res['skillId'] = $this->skillId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return result
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['executeResult'])) {
            $model->executeResult = $map['executeResult'];
        }
        if (isset($map['skillId'])) {
            $model->skillId = $map['skillId'];
        }

        return $model;
    }
}
