<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models\AISaleTaskResultResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @var string
     */
    public $taskResult;

    /**
     * @var int
     */
    public $taskStatus;
    protected $_name = [
        'taskResult' => 'taskResult',
        'taskStatus' => 'taskStatus',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->taskResult) {
            $res['taskResult'] = $this->taskResult;
        }
        if (null !== $this->taskStatus) {
            $res['taskStatus'] = $this->taskStatus;
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
        if (isset($map['taskResult'])) {
            $model->taskResult = $map['taskResult'];
        }
        if (isset($map['taskStatus'])) {
            $model->taskStatus = $map['taskStatus'];
        }

        return $model;
    }
}
