<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetUploadInfoRequest extends Model
{
    /**
     * @var string
     */
    public $addConflictPolicy;

    /**
     * @var string
     */
    public $callerRegion;

    /**
     * @var string
     */
    public $fileName;

    /**
     * @var int
     */
    public $fileSize;

    /**
     * @var string
     */
    public $md5;

    /**
     * @var string
     */
    public $mediaId;

    /**
     * @var string
     */
    public $unionId;

    /**
     * @var bool
     */
    public $withInternalEndPoint;

    /**
     * @var bool
     */
    public $withRegion;
    protected $_name = [
        'addConflictPolicy'    => 'addConflictPolicy',
        'callerRegion'         => 'callerRegion',
        'fileName'             => 'fileName',
        'fileSize'             => 'fileSize',
        'md5'                  => 'md5',
        'mediaId'              => 'mediaId',
        'unionId'              => 'unionId',
        'withInternalEndPoint' => 'withInternalEndPoint',
        'withRegion'           => 'withRegion',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->addConflictPolicy) {
            $res['addConflictPolicy'] = $this->addConflictPolicy;
        }
        if (null !== $this->callerRegion) {
            $res['callerRegion'] = $this->callerRegion;
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
        if (null !== $this->mediaId) {
            $res['mediaId'] = $this->mediaId;
        }
        if (null !== $this->unionId) {
            $res['unionId'] = $this->unionId;
        }
        if (null !== $this->withInternalEndPoint) {
            $res['withInternalEndPoint'] = $this->withInternalEndPoint;
        }
        if (null !== $this->withRegion) {
            $res['withRegion'] = $this->withRegion;
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
        if (isset($map['addConflictPolicy'])) {
            $model->addConflictPolicy = $map['addConflictPolicy'];
        }
        if (isset($map['callerRegion'])) {
            $model->callerRegion = $map['callerRegion'];
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
        if (isset($map['mediaId'])) {
            $model->mediaId = $map['mediaId'];
        }
        if (isset($map['unionId'])) {
            $model->unionId = $map['unionId'];
        }
        if (isset($map['withInternalEndPoint'])) {
            $model->withInternalEndPoint = $map['withInternalEndPoint'];
        }
        if (isset($map['withRegion'])) {
            $model->withRegion = $map['withRegion'];
        }

        return $model;
    }
}
