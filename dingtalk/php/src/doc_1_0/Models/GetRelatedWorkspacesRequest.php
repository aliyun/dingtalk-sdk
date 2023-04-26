<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetRelatedWorkspacesRequest extends Model
{
    /**
     * @var bool
     */
    public $includeRecent;

    /**
     * @var string
     */
    public $operatorId;
    protected $_name = [
        'includeRecent' => 'includeRecent',
        'operatorId'    => 'operatorId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->includeRecent) {
            $res['includeRecent'] = $this->includeRecent;
        }
        if (null !== $this->operatorId) {
            $res['operatorId'] = $this->operatorId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetRelatedWorkspacesRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['includeRecent'])) {
            $model->includeRecent = $map['includeRecent'];
        }
        if (isset($map['operatorId'])) {
            $model->operatorId = $map['operatorId'];
        }

        return $model;
    }
}
