<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vmcp_1_0\Models;

use AlibabaCloud\Tea\Model;

class ActivateMcpResponseBody extends Model
{
    /**
     * @var string
     */
    public $instanceId;

    /**
     * @var string
     */
    public $jsonConfig;

    /**
     * @var string
     */
    public $url;
    protected $_name = [
        'instanceId' => 'instanceId',
        'jsonConfig' => 'jsonConfig',
        'url' => 'url',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->instanceId) {
            $res['instanceId'] = $this->instanceId;
        }
        if (null !== $this->jsonConfig) {
            $res['jsonConfig'] = $this->jsonConfig;
        }
        if (null !== $this->url) {
            $res['url'] = $this->url;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ActivateMcpResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['instanceId'])) {
            $model->instanceId = $map['instanceId'];
        }
        if (isset($map['jsonConfig'])) {
            $model->jsonConfig = $map['jsonConfig'];
        }
        if (isset($map['url'])) {
            $model->url = $map['url'];
        }

        return $model;
    }
}
