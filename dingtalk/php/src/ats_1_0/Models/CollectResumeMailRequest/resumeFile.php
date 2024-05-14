<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vats_1_0\Models\CollectResumeMailRequest;

use AlibabaCloud\Tea\Model;

class resumeFile extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example http:www.xxx.com
     *
     * @var string
     */
    public $downloadUrl;

    /**
     * @description This parameter is required.
     *
     * @example xxxx的简历.pdf
     *
     * @var string
     */
    public $fileName;

    /**
     * @description This parameter is required.
     *
     * @example pdf
     *
     * @var string
     */
    public $fileType;
    protected $_name = [
        'downloadUrl' => 'downloadUrl',
        'fileName'    => 'fileName',
        'fileType'    => 'fileType',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->downloadUrl) {
            $res['downloadUrl'] = $this->downloadUrl;
        }
        if (null !== $this->fileName) {
            $res['fileName'] = $this->fileName;
        }
        if (null !== $this->fileType) {
            $res['fileType'] = $this->fileType;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return resumeFile
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['downloadUrl'])) {
            $model->downloadUrl = $map['downloadUrl'];
        }
        if (isset($map['fileName'])) {
            $model->fileName = $map['fileName'];
        }
        if (isset($map['fileType'])) {
            $model->fileType = $map['fileType'];
        }

        return $model;
    }
}
