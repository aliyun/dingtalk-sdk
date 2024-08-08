<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryScreenTemplateResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @var string
     */
    public $previewUrl;

    /**
     * @var string
     */
    public $screenSize;

    /**
     * @var string
     */
    public $templateId;

    /**
     * @var string
     */
    public $templateName;

    /**
     * @var string
     */
    public $thumbUrl;
    protected $_name = [
        'previewUrl'   => 'previewUrl',
        'screenSize'   => 'screenSize',
        'templateId'   => 'templateId',
        'templateName' => 'templateName',
        'thumbUrl'     => 'thumbUrl',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->previewUrl) {
            $res['previewUrl'] = $this->previewUrl;
        }
        if (null !== $this->screenSize) {
            $res['screenSize'] = $this->screenSize;
        }
        if (null !== $this->templateId) {
            $res['templateId'] = $this->templateId;
        }
        if (null !== $this->templateName) {
            $res['templateName'] = $this->templateName;
        }
        if (null !== $this->thumbUrl) {
            $res['thumbUrl'] = $this->thumbUrl;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return result
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['previewUrl'])) {
            $model->previewUrl = $map['previewUrl'];
        }
        if (isset($map['screenSize'])) {
            $model->screenSize = $map['screenSize'];
        }
        if (isset($map['templateId'])) {
            $model->templateId = $map['templateId'];
        }
        if (isset($map['templateName'])) {
            $model->templateName = $map['templateName'];
        }
        if (isset($map['thumbUrl'])) {
            $model->thumbUrl = $map['thumbUrl'];
        }

        return $model;
    }
}
