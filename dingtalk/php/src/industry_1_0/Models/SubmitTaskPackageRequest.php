<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\SubmitTaskPackageRequest\data;
use AlibabaCloud\Tea\Model;

class SubmitTaskPackageRequest extends Model
{
    /**
     * @var int
     */
    public $appId;

    /**
     * @var string
     */
    public $appSecret;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $bizCode;

    /**
     * @var data[]
     */
    public $data;

    /**
     * @var string
     */
    public $desc;

    /**
     * @var string
     */
    public $fileType;

    /**
     * @var string
     */
    public $taskPackageName;

    /**
     * @var string
     */
    public $version;
    protected $_name = [
        'appId'           => 'appId',
        'appSecret'       => 'appSecret',
        'bizCode'         => 'bizCode',
        'data'            => 'data',
        'desc'            => 'desc',
        'fileType'        => 'fileType',
        'taskPackageName' => 'taskPackageName',
        'version'         => 'version',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->appId) {
            $res['appId'] = $this->appId;
        }
        if (null !== $this->appSecret) {
            $res['appSecret'] = $this->appSecret;
        }
        if (null !== $this->bizCode) {
            $res['bizCode'] = $this->bizCode;
        }
        if (null !== $this->data) {
            $res['data'] = [];
            if (null !== $this->data && \is_array($this->data)) {
                $n = 0;
                foreach ($this->data as $item) {
                    $res['data'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->desc) {
            $res['desc'] = $this->desc;
        }
        if (null !== $this->fileType) {
            $res['fileType'] = $this->fileType;
        }
        if (null !== $this->taskPackageName) {
            $res['taskPackageName'] = $this->taskPackageName;
        }
        if (null !== $this->version) {
            $res['version'] = $this->version;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return SubmitTaskPackageRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['appId'])) {
            $model->appId = $map['appId'];
        }
        if (isset($map['appSecret'])) {
            $model->appSecret = $map['appSecret'];
        }
        if (isset($map['bizCode'])) {
            $model->bizCode = $map['bizCode'];
        }
        if (isset($map['data'])) {
            if (!empty($map['data'])) {
                $model->data = [];
                $n           = 0;
                foreach ($map['data'] as $item) {
                    $model->data[$n++] = null !== $item ? data::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['desc'])) {
            $model->desc = $map['desc'];
        }
        if (isset($map['fileType'])) {
            $model->fileType = $map['fileType'];
        }
        if (isset($map['taskPackageName'])) {
            $model->taskPackageName = $map['taskPackageName'];
        }
        if (isset($map['version'])) {
            $model->version = $map['version'];
        }

        return $model;
    }
}
