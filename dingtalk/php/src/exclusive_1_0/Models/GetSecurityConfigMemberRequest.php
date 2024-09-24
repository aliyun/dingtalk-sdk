<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetSecurityConfigMemberRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example ctrl.xxx
     *
     * @var string
     */
    public $configKey;

    /**
     * @description This parameter is required.
     *
     * @var int
     */
    public $maxResults;

    /**
     * @description This parameter is required.
     *
     * @var float
     */
    public $nextToken;
    protected $_name = [
        'configKey'  => 'configKey',
        'maxResults' => 'maxResults',
        'nextToken'  => 'nextToken',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->configKey) {
            $res['configKey'] = $this->configKey;
        }
        if (null !== $this->maxResults) {
            $res['maxResults'] = $this->maxResults;
        }
        if (null !== $this->nextToken) {
            $res['nextToken'] = $this->nextToken;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetSecurityConfigMemberRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['configKey'])) {
            $model->configKey = $map['configKey'];
        }
        if (isset($map['maxResults'])) {
            $model->maxResults = $map['maxResults'];
        }
        if (isset($map['nextToken'])) {
            $model->nextToken = $map['nextToken'];
        }

        return $model;
    }
}
