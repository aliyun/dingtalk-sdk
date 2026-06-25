<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vmicro_app_1_0\Models;

use AlibabaCloud\Tea\Model;

class SubmitCreateEnterpriseAgentRequest extends Model
{
    /**
     * @var string
     */
    public $appName;

    /**
     * @var string
     */
    public $desc;

    /**
     * @var string
     */
    public $previewMediaId;

    /**
     * @var string
     */
    public $robotMediaId;

    /**
     * @var string
     */
    public $robotName;

    /**
     * @var string
     */
    public $taskId;

    /**
     * @var string
     */
    public $userid;
    protected $_name = [
        'appName' => 'appName',
        'desc' => 'desc',
        'previewMediaId' => 'previewMediaId',
        'robotMediaId' => 'robotMediaId',
        'robotName' => 'robotName',
        'taskId' => 'taskId',
        'userid' => 'userid',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->appName) {
            $res['appName'] = $this->appName;
        }
        if (null !== $this->desc) {
            $res['desc'] = $this->desc;
        }
        if (null !== $this->previewMediaId) {
            $res['previewMediaId'] = $this->previewMediaId;
        }
        if (null !== $this->robotMediaId) {
            $res['robotMediaId'] = $this->robotMediaId;
        }
        if (null !== $this->robotName) {
            $res['robotName'] = $this->robotName;
        }
        if (null !== $this->taskId) {
            $res['taskId'] = $this->taskId;
        }
        if (null !== $this->userid) {
            $res['userid'] = $this->userid;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return SubmitCreateEnterpriseAgentRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['appName'])) {
            $model->appName = $map['appName'];
        }
        if (isset($map['desc'])) {
            $model->desc = $map['desc'];
        }
        if (isset($map['previewMediaId'])) {
            $model->previewMediaId = $map['previewMediaId'];
        }
        if (isset($map['robotMediaId'])) {
            $model->robotMediaId = $map['robotMediaId'];
        }
        if (isset($map['robotName'])) {
            $model->robotName = $map['robotName'];
        }
        if (isset($map['taskId'])) {
            $model->taskId = $map['taskId'];
        }
        if (isset($map['userid'])) {
            $model->userid = $map['userid'];
        }

        return $model;
    }
}
