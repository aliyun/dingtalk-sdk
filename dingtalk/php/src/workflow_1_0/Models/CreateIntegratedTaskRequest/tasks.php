<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\CreateIntegratedTaskRequest;

use AlibabaCloud\Tea\Model;

class tasks extends Model
{
    /**
     * @example {\"id\":\"12345\"}
     *
     * @var string
     */
    public $customData;

    /**
     * @example 1758643200000
     *
     * @var int
     */
    public $dueTimestamp;

    /**
     * @example https://www.dingtalk.com
     *
     * @var string
     */
    public $url;

    /**
     * @example manager001
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'customData' => 'customData',
        'dueTimestamp' => 'dueTimestamp',
        'url' => 'url',
        'userId' => 'userId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->customData) {
            $res['customData'] = $this->customData;
        }
        if (null !== $this->dueTimestamp) {
            $res['dueTimestamp'] = $this->dueTimestamp;
        }
        if (null !== $this->url) {
            $res['url'] = $this->url;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return tasks
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['customData'])) {
            $model->customData = $map['customData'];
        }
        if (isset($map['dueTimestamp'])) {
            $model->dueTimestamp = $map['dueTimestamp'];
        }
        if (isset($map['url'])) {
            $model->url = $map['url'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
