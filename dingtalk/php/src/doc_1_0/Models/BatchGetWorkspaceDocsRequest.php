<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models;

use AlibabaCloud\Tea\Model;

class BatchGetWorkspaceDocsRequest extends Model
{
    /**
     * @description 查询节点Id
     *
     * @var string[]
     */
    public $nodeIds;

    /**
     * @description 操作用户unionId
     *
     * @var string
     */
    public $operatorId;
    protected $_name = [
        'nodeIds'    => 'nodeIds',
        'operatorId' => 'operatorId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->nodeIds) {
            $res['nodeIds'] = $this->nodeIds;
        }
        if (null !== $this->operatorId) {
            $res['operatorId'] = $this->operatorId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return BatchGetWorkspaceDocsRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['nodeIds'])) {
            if (!empty($map['nodeIds'])) {
                $model->nodeIds = $map['nodeIds'];
            }
        }
        if (isset($map['operatorId'])) {
            $model->operatorId = $map['operatorId'];
        }

        return $model;
    }
}
