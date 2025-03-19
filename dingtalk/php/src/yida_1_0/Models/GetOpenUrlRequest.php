<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetOpenUrlRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example https://www.aliwork.com/fileHandle?appType=APP_VN7I6HVKUTXES7XX4OI8&fileName=2a4103a6-44d5-4114-990d-4147a2d53811.xlsx&instId=&type=download
     *
     * @var string
     */
    public $fileUrl;

    /**
     * @example zh_CN
     *
     * @var string
     */
    public $language;

    /**
     * @description This parameter is required.
     *
     * @example hexxxx
     *
     * @var string
     */
    public $systemToken;

    /**
     * @example 60000
     *
     * @var int
     */
    public $timeout;

    /**
     * @description This parameter is required.
     *
     * @example 未知
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'fileUrl' => 'fileUrl',
        'language' => 'language',
        'systemToken' => 'systemToken',
        'timeout' => 'timeout',
        'userId' => 'userId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->fileUrl) {
            $res['fileUrl'] = $this->fileUrl;
        }
        if (null !== $this->language) {
            $res['language'] = $this->language;
        }
        if (null !== $this->systemToken) {
            $res['systemToken'] = $this->systemToken;
        }
        if (null !== $this->timeout) {
            $res['timeout'] = $this->timeout;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetOpenUrlRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['fileUrl'])) {
            $model->fileUrl = $map['fileUrl'];
        }
        if (isset($map['language'])) {
            $model->language = $map['language'];
        }
        if (isset($map['systemToken'])) {
            $model->systemToken = $map['systemToken'];
        }
        if (isset($map['timeout'])) {
            $model->timeout = $map['timeout'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
