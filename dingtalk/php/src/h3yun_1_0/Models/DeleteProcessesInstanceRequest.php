<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vh3yun_1_0\Models;

use AlibabaCloud\Tea\Model;

class DeleteProcessesInstanceRequest extends Model
{
    /**
     * @description 流程实例id
     *
     * @var string
     */
    public $processInstanceId;

    /**
     * @description 删除成功后，是否需要更新业务表单关联的流程实例id
     *
     * @var bool
     */
    public $isAutoUpdateBizObject;
    protected $_name = [
        'processInstanceId'     => 'processInstanceId',
        'isAutoUpdateBizObject' => 'isAutoUpdateBizObject',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->processInstanceId) {
            $res['processInstanceId'] = $this->processInstanceId;
        }
        if (null !== $this->isAutoUpdateBizObject) {
            $res['isAutoUpdateBizObject'] = $this->isAutoUpdateBizObject;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return DeleteProcessesInstanceRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['processInstanceId'])) {
            $model->processInstanceId = $map['processInstanceId'];
        }
        if (isset($map['isAutoUpdateBizObject'])) {
            $model->isAutoUpdateBizObject = $map['isAutoUpdateBizObject'];
        }

        return $model;
    }
}
