<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models;

use AlibabaCloud\Tea\Model;

class EmployeeAttachmentUpdateRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var int
     */
    public $appAgentId;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $fieldCode;

    /**
     * @example .png
     *
     * @var string
     */
    public $fileSuffix;

    /**
     * @description This parameter is required.
     *
     * @example "$iAEKAqNwbmcDBgTNAk"
     *
     * @var string
     */
    public $mediaId;

    /**
     * @description This parameter is required.
     *
     * @example admin123
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'appAgentId' => 'appAgentId',
        'fieldCode'  => 'fieldCode',
        'fileSuffix' => 'fileSuffix',
        'mediaId'    => 'mediaId',
        'userId'     => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->appAgentId) {
            $res['appAgentId'] = $this->appAgentId;
        }
        if (null !== $this->fieldCode) {
            $res['fieldCode'] = $this->fieldCode;
        }
        if (null !== $this->fileSuffix) {
            $res['fileSuffix'] = $this->fileSuffix;
        }
        if (null !== $this->mediaId) {
            $res['mediaId'] = $this->mediaId;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return EmployeeAttachmentUpdateRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['appAgentId'])) {
            $model->appAgentId = $map['appAgentId'];
        }
        if (isset($map['fieldCode'])) {
            $model->fieldCode = $map['fieldCode'];
        }
        if (isset($map['fileSuffix'])) {
            $model->fileSuffix = $map['fileSuffix'];
        }
        if (isset($map['mediaId'])) {
            $model->mediaId = $map['mediaId'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
