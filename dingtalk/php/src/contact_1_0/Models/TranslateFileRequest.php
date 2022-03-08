<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models;

use AlibabaCloud\Tea\Model;

class TranslateFileRequest extends Model
{
    /**
     * @description key为钉盘文件mediaId，#号开头。只支持xlsx，xls，csv，txt文件。 value为文件名，包含文件扩展名。 不超过20个文件，可以调用单步文件上传接口获取。
     *
     * @var string[]
     */
    public $medias;

    /**
     * @description 若medias中文件个数大于1，则该字段必填。 转译完打包的文件名，不需带后缀。钉钉后台会打包成zip压缩文件，并自动拼接上.zip后缀。
     *
     * @var string
     */
    public $outputFileName;

    /**
     * @description unionId
     *
     * @var string
     */
    public $unionId;
    protected $_name = [
        'medias'         => 'medias',
        'outputFileName' => 'outputFileName',
        'unionId'        => 'unionId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->medias) {
            $res['medias'] = $this->medias;
        }
        if (null !== $this->outputFileName) {
            $res['outputFileName'] = $this->outputFileName;
        }
        if (null !== $this->unionId) {
            $res['unionId'] = $this->unionId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return TranslateFileRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['medias'])) {
            $model->medias = $map['medias'];
        }
        if (isset($map['outputFileName'])) {
            $model->outputFileName = $map['outputFileName'];
        }
        if (isset($map['unionId'])) {
            $model->unionId = $map['unionId'];
        }

        return $model;
    }
}
