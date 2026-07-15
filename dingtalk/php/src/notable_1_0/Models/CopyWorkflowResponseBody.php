<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vnotable_1_0\Models;

use AlibabaCloud\Tea\Model;

class CopyWorkflowResponseBody extends Model
{
    /**
     * @var string
     */
    public $flowId;

    /**
     * @var bool
     */
    public $success;

    /**
     * @var string
     */
    public $versionId;
    protected $_name = [
        'flowId' => 'flowId',
        'success' => 'success',
        'versionId' => 'versionId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->flowId) {
            $res['flowId'] = $this->flowId;
        }
        if (null !== $this->success) {
            $res['success'] = $this->success;
        }
        if (null !== $this->versionId) {
            $res['versionId'] = $this->versionId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CopyWorkflowResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['flowId'])) {
            $model->flowId = $map['flowId'];
        }
        if (isset($map['success'])) {
            $model->success = $map['success'];
        }
        if (isset($map['versionId'])) {
            $model->versionId = $map['versionId'];
        }

        return $model;
    }
}
