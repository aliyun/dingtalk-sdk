<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models;

use AlibabaCloud\Tea\Model;

class DeleteProcessRequest extends Model
{
    /**
     * @description 是否清理正在运行的任务
     *
     * @var bool
     */
    public $cleanRunningTask;

    /**
     * @description 模板code
     *
     * @var string
     */
    public $processCode;
    protected $_name = [
        'cleanRunningTask' => 'cleanRunningTask',
        'processCode'      => 'processCode',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->cleanRunningTask) {
            $res['cleanRunningTask'] = $this->cleanRunningTask;
        }
        if (null !== $this->processCode) {
            $res['processCode'] = $this->processCode;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return DeleteProcessRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['cleanRunningTask'])) {
            $model->cleanRunningTask = $map['cleanRunningTask'];
        }
        if (isset($map['processCode'])) {
            $model->processCode = $map['processCode'];
        }

        return $model;
    }
}
