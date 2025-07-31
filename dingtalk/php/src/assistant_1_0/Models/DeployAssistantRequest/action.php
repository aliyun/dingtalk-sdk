<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vassistant_1_0\Models\DeployAssistantRequest;

use AlibabaCloud\SDK\Dingtalk\Vassistant_1_0\Models\DeployAssistantRequest\action\actionAuthInfo;
use AlibabaCloud\Tea\Model;

class action extends Model
{
    /**
     * @var actionAuthInfo
     */
    public $actionAuthInfo;

    /**
     * @var string
     */
    public $actionName;

    /**
     * @var string
     */
    public $description;

    /**
     * @var string
     */
    public $schema;
    protected $_name = [
        'actionAuthInfo' => 'actionAuthInfo',
        'actionName' => 'actionName',
        'description' => 'description',
        'schema' => 'schema',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->actionAuthInfo) {
            $res['actionAuthInfo'] = null !== $this->actionAuthInfo ? $this->actionAuthInfo->toMap() : null;
        }
        if (null !== $this->actionName) {
            $res['actionName'] = $this->actionName;
        }
        if (null !== $this->description) {
            $res['description'] = $this->description;
        }
        if (null !== $this->schema) {
            $res['schema'] = $this->schema;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return action
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['actionAuthInfo'])) {
            $model->actionAuthInfo = actionAuthInfo::fromMap($map['actionAuthInfo']);
        }
        if (isset($map['actionName'])) {
            $model->actionName = $map['actionName'];
        }
        if (isset($map['description'])) {
            $model->description = $map['description'];
        }
        if (isset($map['schema'])) {
            $model->schema = $map['schema'];
        }

        return $model;
    }
}
