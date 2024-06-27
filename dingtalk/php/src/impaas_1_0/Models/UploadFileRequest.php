<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vimpaas_1_0\Models;

use AlibabaCloud\Tea\Model;

class UploadFileRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 111.png
     *
     * @var string
     */
    public $fileName;

    /**
     * @description This parameter is required.
     *
     * @example image
     *
     * @var string
     */
    public $fileType;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $fileUrl;

    /**
     * @description This parameter is required.
     *
     * @example 111@dingdingkelian
     *
     * @var string
     */
    public $senderUid;
    protected $_name = [
        'fileName'  => 'fileName',
        'fileType'  => 'fileType',
        'fileUrl'   => 'fileUrl',
        'senderUid' => 'senderUid',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->fileName) {
            $res['fileName'] = $this->fileName;
        }
        if (null !== $this->fileType) {
            $res['fileType'] = $this->fileType;
        }
        if (null !== $this->fileUrl) {
            $res['fileUrl'] = $this->fileUrl;
        }
        if (null !== $this->senderUid) {
            $res['senderUid'] = $this->senderUid;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UploadFileRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['fileName'])) {
            $model->fileName = $map['fileName'];
        }
        if (isset($map['fileType'])) {
            $model->fileType = $map['fileType'];
        }
        if (isset($map['fileUrl'])) {
            $model->fileUrl = $map['fileUrl'];
        }
        if (isset($map['senderUid'])) {
            $model->senderUid = $map['senderUid'];
        }

        return $model;
    }
}
