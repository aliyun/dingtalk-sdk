<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetUploadInfoRequest extends Model
{
    /**
     * @description 用户id
     *
     * @var string
     */
    public $unionId;

    /**
     * @description 文件名
     *
     * @var string
     */
    public $fileName;

    /**
     * @description 文件大小
     *
     * @var int
     */
    public $fileSize;

    /**
     * @description 文件md5
     *
     * @var string
     */
    public $md5;

    /**
     * @description 文件名称冲突策略
     *
     * @var string
     */
    public $addConflictPolicy;

    /**
     * @description mediaId
     *
     * @var string
     */
    public $mediaId;

    /**
     * @description 是否返回区域
     *
     * @var bool
     */
    public $withRegion;

    /**
     * @description 是否返回OSS内网访问域名
     *
     * @var bool
     */
    public $withInternalEndPoint;

    /**
     * @description 调用方所处区域
     *
     * @var string
     */
    public $callerRegion;
    protected $_name = [
        'unionId'              => 'unionId',
        'fileName'             => 'fileName',
        'fileSize'             => 'fileSize',
        'md5'                  => 'md5',
        'addConflictPolicy'    => 'addConflictPolicy',
        'mediaId'              => 'mediaId',
        'withRegion'           => 'withRegion',
        'withInternalEndPoint' => 'withInternalEndPoint',
        'callerRegion'         => 'callerRegion',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->unionId) {
            $res['unionId'] = $this->unionId;
        }
        if (null !== $this->fileName) {
            $res['fileName'] = $this->fileName;
        }
        if (null !== $this->fileSize) {
            $res['fileSize'] = $this->fileSize;
        }
        if (null !== $this->md5) {
            $res['md5'] = $this->md5;
        }
        if (null !== $this->addConflictPolicy) {
            $res['addConflictPolicy'] = $this->addConflictPolicy;
        }
        if (null !== $this->mediaId) {
            $res['mediaId'] = $this->mediaId;
        }
        if (null !== $this->withRegion) {
            $res['withRegion'] = $this->withRegion;
        }
        if (null !== $this->withInternalEndPoint) {
            $res['withInternalEndPoint'] = $this->withInternalEndPoint;
        }
        if (null !== $this->callerRegion) {
            $res['callerRegion'] = $this->callerRegion;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetUploadInfoRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['unionId'])) {
            $model->unionId = $map['unionId'];
        }
        if (isset($map['fileName'])) {
            $model->fileName = $map['fileName'];
        }
        if (isset($map['fileSize'])) {
            $model->fileSize = $map['fileSize'];
        }
        if (isset($map['md5'])) {
            $model->md5 = $map['md5'];
        }
        if (isset($map['addConflictPolicy'])) {
            $model->addConflictPolicy = $map['addConflictPolicy'];
        }
        if (isset($map['mediaId'])) {
            $model->mediaId = $map['mediaId'];
        }
        if (isset($map['withRegion'])) {
            $model->withRegion = $map['withRegion'];
        }
        if (isset($map['withInternalEndPoint'])) {
            $model->withInternalEndPoint = $map['withInternalEndPoint'];
        }
        if (isset($map['callerRegion'])) {
            $model->callerRegion = $map['callerRegion'];
        }

        return $model;
    }
}
