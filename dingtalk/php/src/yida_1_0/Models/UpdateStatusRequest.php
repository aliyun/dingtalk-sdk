<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models;

use AlibabaCloud\Tea\Model;

class UpdateStatusRequest extends Model
{
    /**
     * @var string
     */
    public $appType;

    /**
     * @var int[]
     */
    public $errorLines;

    /**
     * @var string
     */
    public $importSequence;

    /**
     * @var string
     */
    public $language;

    /**
     * @var string
     */
    public $status;

    /**
     * @var string
     */
    public $systemToken;

    /**
     * @var string
     */
    public $userId;
    protected $_name = [
        'appType'        => 'appType',
        'errorLines'     => 'errorLines',
        'importSequence' => 'importSequence',
        'language'       => 'language',
        'status'         => 'status',
        'systemToken'    => 'systemToken',
        'userId'         => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->appType) {
            $res['appType'] = $this->appType;
        }
        if (null !== $this->errorLines) {
            $res['errorLines'] = $this->errorLines;
        }
        if (null !== $this->importSequence) {
            $res['importSequence'] = $this->importSequence;
        }
        if (null !== $this->language) {
            $res['language'] = $this->language;
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }
        if (null !== $this->systemToken) {
            $res['systemToken'] = $this->systemToken;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
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
        if (isset($map['appType'])) {
            $model->appType = $map['appType'];
        }
        if (isset($map['errorLines'])) {
            if (!empty($map['errorLines'])) {
                $model->errorLines = $map['errorLines'];
            }
        }
        if (isset($map['importSequence'])) {
            $model->importSequence = $map['importSequence'];
        }
        if (isset($map['language'])) {
            $model->language = $map['language'];
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }
        if (isset($map['systemToken'])) {
            $model->systemToken = $map['systemToken'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
