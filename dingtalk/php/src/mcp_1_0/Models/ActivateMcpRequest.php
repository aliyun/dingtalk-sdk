<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vmcp_1_0\Models;

use AlibabaCloud\Tea\Model;

class ActivateMcpRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var int
     */
    public $mcpId;

    /**
     * @var string
     */
    public $source;
    protected $_name = [
        'mcpId' => 'mcpId',
        'source' => 'source',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->mcpId) {
            $res['mcpId'] = $this->mcpId;
        }
        if (null !== $this->source) {
            $res['source'] = $this->source;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ActivateMcpRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['mcpId'])) {
            $model->mcpId = $map['mcpId'];
        }
        if (isset($map['source'])) {
            $model->source = $map['source'];
        }

        return $model;
    }
}
