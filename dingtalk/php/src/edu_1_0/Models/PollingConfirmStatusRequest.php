<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\Tea\Model;

class PollingConfirmStatusRequest extends Model
{
    /**
     * @description courseCode
     *
     * @var string
     */
    public $courseCode;

    /**
     * @description ext
     *
     * @var string
     */
    public $ext;

    /**
     * @description isvCode
     *
     * @var string
     */
    public $isvCode;

    /**
     * @description opUserId
     *
     * @var string
     */
    public $opUserId;
    protected $_name = [
        'courseCode' => 'courseCode',
        'ext'        => 'ext',
        'isvCode'    => 'isvCode',
        'opUserId'   => 'opUserId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->courseCode) {
            $res['courseCode'] = $this->courseCode;
        }
        if (null !== $this->ext) {
            $res['ext'] = $this->ext;
        }
        if (null !== $this->isvCode) {
            $res['isvCode'] = $this->isvCode;
        }
        if (null !== $this->opUserId) {
            $res['opUserId'] = $this->opUserId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return PollingConfirmStatusRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['courseCode'])) {
            $model->courseCode = $map['courseCode'];
        }
        if (isset($map['ext'])) {
            $model->ext = $map['ext'];
        }
        if (isset($map['isvCode'])) {
            $model->isvCode = $map['isvCode'];
        }
        if (isset($map['opUserId'])) {
            $model->opUserId = $map['opUserId'];
        }

        return $model;
    }
}
