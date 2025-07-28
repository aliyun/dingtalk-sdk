<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\SubmitTaskPackageRequest;

use AlibabaCloud\Tea\Model;

class data extends Model
{
    /**
     * @var string
     */
    public $extension;

    /**
     * @var string
     */
    public $fileUrl;

    /**
     * @var string[]
     */
    public $fileUrls;

    /**
     * @var string
     */
    public $taskName;

    /**
     * @var string
     */
    public $textContent;
    protected $_name = [
        'extension' => 'extension',
        'fileUrl' => 'fileUrl',
        'fileUrls' => 'fileUrls',
        'taskName' => 'taskName',
        'textContent' => 'textContent',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->extension) {
            $res['extension'] = $this->extension;
        }
        if (null !== $this->fileUrl) {
            $res['fileUrl'] = $this->fileUrl;
        }
        if (null !== $this->fileUrls) {
            $res['fileUrls'] = $this->fileUrls;
        }
        if (null !== $this->taskName) {
            $res['taskName'] = $this->taskName;
        }
        if (null !== $this->textContent) {
            $res['textContent'] = $this->textContent;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return data
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['extension'])) {
            $model->extension = $map['extension'];
        }
        if (isset($map['fileUrl'])) {
            $model->fileUrl = $map['fileUrl'];
        }
        if (isset($map['fileUrls'])) {
            if (!empty($map['fileUrls'])) {
                $model->fileUrls = $map['fileUrls'];
            }
        }
        if (isset($map['taskName'])) {
            $model->taskName = $map['taskName'];
        }
        if (isset($map['textContent'])) {
            $model->textContent = $map['textContent'];
        }

        return $model;
    }
}
