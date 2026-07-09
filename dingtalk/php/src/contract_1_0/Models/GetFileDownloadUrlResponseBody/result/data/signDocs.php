<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\GetFileDownloadUrlResponseBody\result\data;

use AlibabaCloud\Tea\Model;

class signDocs extends Model
{
    /**
     * @var string
     */
    public $downloadUrl;

    /**
     * @var string
     */
    public $fileId;

    /**
     * @var string
     */
    public $fileName;

    /**
     * @var string
     */
    public $fileStatus;

    /**
     * @var int
     */
    public $urlExpireTime;
    protected $_name = [
        'downloadUrl' => 'downloadUrl',
        'fileId' => 'fileId',
        'fileName' => 'fileName',
        'fileStatus' => 'fileStatus',
        'urlExpireTime' => 'urlExpireTime',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->downloadUrl) {
            $res['downloadUrl'] = $this->downloadUrl;
        }
        if (null !== $this->fileId) {
            $res['fileId'] = $this->fileId;
        }
        if (null !== $this->fileName) {
            $res['fileName'] = $this->fileName;
        }
        if (null !== $this->fileStatus) {
            $res['fileStatus'] = $this->fileStatus;
        }
        if (null !== $this->urlExpireTime) {
            $res['urlExpireTime'] = $this->urlExpireTime;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return signDocs
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['downloadUrl'])) {
            $model->downloadUrl = $map['downloadUrl'];
        }
        if (isset($map['fileId'])) {
            $model->fileId = $map['fileId'];
        }
        if (isset($map['fileName'])) {
            $model->fileName = $map['fileName'];
        }
        if (isset($map['fileStatus'])) {
            $model->fileStatus = $map['fileStatus'];
        }
        if (isset($map['urlExpireTime'])) {
            $model->urlExpireTime = $map['urlExpireTime'];
        }

        return $model;
    }
}
