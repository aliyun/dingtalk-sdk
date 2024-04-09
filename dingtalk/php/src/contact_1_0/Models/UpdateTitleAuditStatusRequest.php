<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models;

use AlibabaCloud\Tea\Model;

class UpdateTitleAuditStatusRequest extends Model
{
    /**
     * @var string
     */
    public $authStatus;

    /**
     * @var string
     */
    public $educationLevel;

    /**
     * @var string
     */
    public $extension;

    /**
     * @var string
     */
    public $major;

    /**
     * @var string
     */
    public $position;

    /**
     * @var string
     */
    public $reasonCode;

    /**
     * @var string
     */
    public $reasonMsg;

    /**
     * @var string
     */
    public $school;

    /**
     * @var string
     */
    public $type;

    /**
     * @var string
     */
    public $unionId;

    /**
     * @var string
     */
    public $uuid;
    protected $_name = [
        'authStatus'     => 'authStatus',
        'educationLevel' => 'educationLevel',
        'extension'      => 'extension',
        'major'          => 'major',
        'position'       => 'position',
        'reasonCode'     => 'reasonCode',
        'reasonMsg'      => 'reasonMsg',
        'school'         => 'school',
        'type'           => 'type',
        'unionId'        => 'unionId',
        'uuid'           => 'uuid',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->authStatus) {
            $res['authStatus'] = $this->authStatus;
        }
        if (null !== $this->educationLevel) {
            $res['educationLevel'] = $this->educationLevel;
        }
        if (null !== $this->extension) {
            $res['extension'] = $this->extension;
        }
        if (null !== $this->major) {
            $res['major'] = $this->major;
        }
        if (null !== $this->position) {
            $res['position'] = $this->position;
        }
        if (null !== $this->reasonCode) {
            $res['reasonCode'] = $this->reasonCode;
        }
        if (null !== $this->reasonMsg) {
            $res['reasonMsg'] = $this->reasonMsg;
        }
        if (null !== $this->school) {
            $res['school'] = $this->school;
        }
        if (null !== $this->type) {
            $res['type'] = $this->type;
        }
        if (null !== $this->unionId) {
            $res['unionId'] = $this->unionId;
        }
        if (null !== $this->uuid) {
            $res['uuid'] = $this->uuid;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UpdateTitleAuditStatusRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['authStatus'])) {
            $model->authStatus = $map['authStatus'];
        }
        if (isset($map['educationLevel'])) {
            $model->educationLevel = $map['educationLevel'];
        }
        if (isset($map['extension'])) {
            $model->extension = $map['extension'];
        }
        if (isset($map['major'])) {
            $model->major = $map['major'];
        }
        if (isset($map['position'])) {
            $model->position = $map['position'];
        }
        if (isset($map['reasonCode'])) {
            $model->reasonCode = $map['reasonCode'];
        }
        if (isset($map['reasonMsg'])) {
            $model->reasonMsg = $map['reasonMsg'];
        }
        if (isset($map['school'])) {
            $model->school = $map['school'];
        }
        if (isset($map['type'])) {
            $model->type = $map['type'];
        }
        if (isset($map['unionId'])) {
            $model->unionId = $map['unionId'];
        }
        if (isset($map['uuid'])) {
            $model->uuid = $map['uuid'];
        }

        return $model;
    }
}
