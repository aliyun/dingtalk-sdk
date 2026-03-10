<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models;

use AlibabaCloud\Tea\Model;

class ControlRecordingRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example bind
     *
     * @var string
     */
    public $action;

    /**
     * @description This parameter is required.
     *
     * @var bool
     */
    public $agree;

    /**
     * @var string
     */
    public $teamCode;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'action' => 'action',
        'agree' => 'agree',
        'teamCode' => 'teamCode',
        'userId' => 'userId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->action) {
            $res['action'] = $this->action;
        }
        if (null !== $this->agree) {
            $res['agree'] = $this->agree;
        }
        if (null !== $this->teamCode) {
            $res['teamCode'] = $this->teamCode;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ControlRecordingRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['action'])) {
            $model->action = $map['action'];
        }
        if (isset($map['agree'])) {
            $model->agree = $map['agree'];
        }
        if (isset($map['teamCode'])) {
            $model->teamCode = $map['teamCode'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
