<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models;

use AlibabaCloud\Tea\Model;

class UpdateStatusRequest extends Model
{
    /**
     * @var string
     */
    public $importSequence;

    /**
     * @var int[]
     */
    public $errorLines;

    /**
     * @var string
     */
    public $appType;

    /**
     * @var string
     */
    public $systemToken;

    /**
     * @var string
     */
    public $language;

    /**
     * @var string
     */
    public $userId;

    /**
     * @var string
     */
    public $status;
    protected $_name = [
        'importSequence' => 'importSequence',
        'errorLines'     => 'errorLines',
        'appType'        => 'appType',
        'systemToken'    => 'systemToken',
        'language'       => 'language',
        'userId'         => 'userId',
        'status'         => 'status',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->importSequence) {
            $res['importSequence'] = $this->importSequence;
        }
        if (null !== $this->errorLines) {
            $res['errorLines'] = $this->errorLines;
        }
        if (null !== $this->appType) {
            $res['appType'] = $this->appType;
        }
        if (null !== $this->systemToken) {
            $res['systemToken'] = $this->systemToken;
        }
        if (null !== $this->language) {
            $res['language'] = $this->language;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UpdateStatusRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['importSequence'])) {
            $model->importSequence = $map['importSequence'];
        }
        if (isset($map['errorLines'])) {
            if (!empty($map['errorLines'])) {
                $model->errorLines = $map['errorLines'];
            }
        }
        if (isset($map['appType'])) {
            $model->appType = $map['appType'];
        }
        if (isset($map['systemToken'])) {
            $model->systemToken = $map['systemToken'];
        }
        if (isset($map['language'])) {
            $model->language = $map['language'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }

        return $model;
    }
}
